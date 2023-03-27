using NationalInstruments.DAQmx;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_DAQ
{
    public class Sensor
    {
        Dictionary<string, string> statusLED = new Dictionary<string, string>()
        {{"SensorTmp36","ON"}, { "SensorThermistor", "ON" }, { "SensorLED","ON" } };
        public bool SensorContact { get; set; }

        public Sensor()
        {
        }
        public double GetDataFromPort(string deviceNameAndPort)
        {
            double returnValue = 0.0;
            try
            {
                NationalInstruments.DAQmx.Task analogInTask = new NationalInstruments.DAQmx.Task();
                AIChannel myAIChannel;
                myAIChannel = analogInTask.AIChannels.CreateVoltageChannel(
                    deviceNameAndPort, "myAiChannel", AITerminalConfiguration.Rse, 0, 5, AIVoltageUnits.Volts);
                AnalogSingleChannelReader reader = new AnalogSingleChannelReader(analogInTask.Stream);
                returnValue = reader.ReadSingleSample();
            }
            catch (Exception error)
            {
                System.Windows.Forms.MessageBox.Show(error.Message);
            }
            return returnValue;
        }
    }
}
