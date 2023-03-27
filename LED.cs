using NationalInstruments.DAQmx;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Media;

namespace Project_DAQ
{
    public class LED
    {
        public LED()
        {

        }
        public void FunMode(LED one, LED two, SoundPlayer soundplayer)
        {
            int counter = 0;
            soundplayer.Play();
            one = new LED();
            two = new LED();
            NationalInstruments.DAQmx.Task contact = new NationalInstruments.DAQmx.Task();
            while (counter < 5)
            {
                one.ChangeLEDStatus("dev1/Port0/line0");
                two.ChangeLEDStatus("dev1/Port0/line1");
                Thread.Sleep(1000);
                counter++;
            }
        }
        public void ResetLED(string deviceNameAndPort)
        {
            try
            {
                NationalInstruments.DAQmx.Task digitalOutTask = new NationalInstruments.DAQmx.Task();
                digitalOutTask.DOChannels.CreateChannel(deviceNameAndPort,
                "myDAChannel",
                ChannelLineGrouping.OneChannelForEachLine);
                DigitalSingleChannelReader reader = new DigitalSingleChannelReader(digitalOutTask.Stream);
                DigitalSingleChannelWriter writer = new DigitalSingleChannelWriter(digitalOutTask.Stream);
                writer.WriteSingleSampleSingleLine(true, false);
            }
            catch (Exception error)
            {

                System.Windows.Forms.MessageBox.Show(error.Message);
            }
        }
        public void SetLEDAutomatic(LED one, LED two, Dictionary <string,string> dictionary, CheckBox checkBox)
        {
            one = new LED();
            two = new LED();
            NationalInstruments.DAQmx.Task contact = new NationalInstruments.DAQmx.Task();
            one.ResetLED("dev1/Port0/line0");
            two.ResetLED("dev1/Port0/line1");
            if (checkBox.Checked == false)
            {


                if (dictionary["SensorTmp36"] == "OFF" && dictionary["SensorThermistor"] == "OFF" && dictionary["SensorLED"] == "OFF")
                {
                    two.ChangeLEDStatus("dev1/Port0/line1");
                }
                else if (dictionary["SensorTmp36"] == "OFF" || dictionary["SensorThermistor"] == "OFF" || dictionary["SensorLED"] == "OFF")
                {
                    one.ChangeLEDStatus("dev1/Port0/line0");
                    two.ChangeLEDStatus("dev1/Port0/line1");
                }
                else if (dictionary["SensorTmp36"] == "ON" || dictionary["SensorThermistor"] == "ON" || dictionary["SensorLED"] == "ON")
                {
                    one.ChangeLEDStatus("dev1/Port0/line0");
                }
            }
        }
        public void ChangeLEDStatus(string deviceNameAndPort)
        {
            bool digitalDataOut, ledCurrentStatus;
            try
            {
                NationalInstruments.DAQmx.Task digitalOutTask = new NationalInstruments.DAQmx.Task();
                digitalOutTask.DOChannels.CreateChannel(deviceNameAndPort,
                "myDAChannel",
                ChannelLineGrouping.OneChannelForEachLine);
                DigitalSingleChannelReader reader = new DigitalSingleChannelReader(digitalOutTask.Stream);
                ledCurrentStatus = reader.ReadSingleSampleSingleLine();
                if (ledCurrentStatus == true)
                {
                    digitalDataOut = false;
                }
                else
                {
                    digitalDataOut = true;
                }
                DigitalSingleChannelWriter writer = new DigitalSingleChannelWriter(digitalOutTask.Stream);
                writer.WriteSingleSampleSingleLine(true, digitalDataOut);
            }
            catch (Exception error)
            {

                System.Windows.Forms.MessageBox.Show(error.Message);
            }
        }
    }
}