using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Project_DAQ
{
    public partial class DataLogging_DAQ_App : Form
    {
        #region #ClasseGroup
        private Sensor sensorTmp36;
        private Sensor sensorThermistor;
        private Sensor sensorLED;
        #endregion
        #region #LEDGroup
        private LED ledGreen = new LED();
        private LED ledRed = new LED();
        #endregion
        Dictionary<string, string> statusLED = new Dictionary<string, string>()
        {{"SensorTmp36","ON"}, { "SensorThermistor", "ON" }, { "SensorLED","ON" } };
        Database database = new Database();
        bool autoUpdateOff = false;
        public DataLogging_DAQ_App()
        {
            InitializeComponent();
            SetOffOnOnSensor();
            ledGreen.SetLEDAutomatic(ledGreen, ledRed, statusLED, chkLed);
        }

        public void SetOffOnOnSensor()  
        {
            txtStatusTmp36.Text = statusLED["SensorTmp36"];
            txtStatusThermistor.Text = statusLED["SensorThermistor"];
            txtStatusLightSensor.Text = statusLED["SensorLED"];
        }

        private void btnGetTmp36data_Click(object sender, EventArgs e)
        {
            sensorTmp36 = new Sensor();
            double voltageOut, tmp36Value;

            voltageOut = sensorTmp36.GetDataFromPort("dev1/ai0");
            tmp36Value = voltageOut * 100 - 50;
            txtTemp36Data.Text = tmp36Value.ToString("0.00");
            database.AddDataToDatabase(tmp36Value, 1);
            if (voltageOut > 1.2)// Tester om det er kontakt med sensor
            {
                statusLED["SensorTmp36"] = "OFF";
            }
            else
            {
                statusLED["SensorTmp36"] = "ON";
            }
            SetOffOnOnSensor();
        }

        private void btnGetTempThermistor_Click(object sender, EventArgs e)
        {
            sensorThermistor = new Sensor();
            double resistanceO, resistanceT, voltageIn, voltageOut, tempK, tempC;

            //Steinhart's constants
            const double A = 0.001129148;
            const double B = 0.000234125;
            const double C = 0.0000000876741;
            resistanceO = 10000.0;//ohm
            voltageIn = 5.0; //volt
            voltageOut = sensorThermistor.GetDataFromPort("dev1/ai1");
            resistanceT = (voltageOut * resistanceO) / (voltageIn - voltageOut);
            tempK = 1 / (A + (B * Math.Log(resistanceT)) + C * Math.Pow(Math.Log(resistanceT), 3)); //temprature in Kelvin
            tempC = tempK - 273.15;
            txtTempThermistor.Text = tempC.ToString("0.00");
            database.AddDataToDatabase(tempC, 2);
            if (voltageOut < 1.41)
            {
                statusLED["SensorThermistor"] = "OFF";
            }
            else
            {
                statusLED["SensorThermistor"] = "ON";
            }
            SetOffOnOnSensor();
        }

        private void btnGetLightsensor_Click(object sender, EventArgs e)
        {
            sensorLED = new Sensor();
            double resistanceO, resistanceT, voltageIn, voltageOut, luxValue;

            resistanceO = 33000.0;//ohm
            voltageIn = 5.0; //volt
            voltageOut = sensorLED.GetDataFromPort("dev1/ai2");
            resistanceT = (voltageOut * resistanceO) / (voltageIn - voltageOut);
            txtLightsensor.Text = voltageOut.ToString("0.00");
            database.AddDataToDatabase(voltageOut, 3);
            if (voltageOut == 1.3975091728893361)
            {
                statusLED["SensorLED"] = "OFF";
            }
            else
            {
                statusLED["SensorLED"] = "ON";
            }
            SetOffOnOnSensor();
        }

        private void btnGreenlight_Click(object sender, EventArgs e)
        {
            if (chkLed.Checked == true)
            {
                ledGreen.ChangeLEDStatus("dev1/Port0/line0");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (chkLed.Checked == true)
            {
                ledRed.ChangeLEDStatus("dev1/Port0/line1");
            }
        }

        private void chkLed_CheckedChanged(object sender, EventArgs e)
        {
            ledGreen.ResetLED("dev1/Port0/line0");
            ledRed.ResetLED("dev1/Port0/line1");

            if (chkLed.Checked == false)
            {
                ledGreen.SetLEDAutomatic(ledGreen, ledRed, statusLED, chkLed);
            }

        }

        private void tmrLEDStatus_Tick(object sender, EventArgs e)
        {
            if (tmrLEDStatus.Interval == 1)
            {
                tmrLEDStatus.Interval = 10000;
            }
            txtTimeInterval.Text = (tmrLEDStatus.Interval / 1000).ToString() + "s";
            ledGreen.ResetLED("dev1/Port0/line0");
            ledRed.ResetLED("dev1/Port0/line1");

            btnGetLightsensor_Click(sender, e);
            btnGetTempThermistor_Click(sender, e);
            btnGetTmp36data_Click(sender, e);
            database.CalculateAverage(1);
            database.CalculateAverage(2);
            database.CalculateAverage(3);
            SetOffOnOnSensor();
            ledGreen.SetLEDAutomatic(ledGreen, ledRed, statusLED, chkLed);

             database.ViewDataInGridView(dgvSensors, autoUpdateOff);
           
        }

        private void infoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This program shows you temperature values from a TMP36 sensor and a thermistor, " +
                "the program also offers you information from a light sensor. \nYou can manually control the LEDs on the breadboard if you " +
                "check off the box, if left unchecked the program automatically controls the LEDs. \nIn auto mode, the green light will be on " +
                "if all three sensors are on, " +
                "if one or two are not on both the green and red LED will light up, if all three are off only the red LED will be on");
        }
            
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This program is made by Zakaria Ahmed, and probably has a lot of bugs!");
        }
        private void timeIntervalToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            string input = Interaction.InputBox("Set time interval value in seconds");
            Console.WriteLine(input);
            tmrLEDStatus.Interval = Convert.ToInt32(input) * 1000;
            tmrLEDStatus_Tick(sender, e);
        }

        private void funModeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer("horn.wav");
            ledGreen.FunMode(ledGreen, ledRed, player);
            ledGreen.ResetLED("dev1/Port0/line0");
            ledRed.ResetLED("dev1/Port0/line1");
        }

        private void dgvSensors_CellMouseMove(object sender, DataGridViewCellMouseEventArgs e)
        {
            autoUpdateOff = true;
        }

        private void dgvSensors_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            autoUpdateOff = false;
        }

        private void DataLogging_DAQ_App_Load(object sender, EventArgs e)
        {

        }
    }
}
