// Written by Thu Rein Oo
// 7/11/2024

using System;
using System.Collections.Generic;
using System.Threading;

namespace IOTDevice
{
    public class IOTDevice
    {
        public string DeviceID { get; set; }
        public double Humidity { get; set; }
        public double Temperature { get; set; }

        public IOTDevice(string deviceId)
        {
            DeviceID = deviceId;
        }

        public void GenerateData()
        {
            Random random = new Random();
            Temperature = random.NextDouble() * 50;  // Generate temperature between 0 and 50
            Humidity = random.NextDouble() * 100;    // Generate humidity between 0 and 100
        }
    }

    class Program
    {
        private static List<IOTDevice> devices = new List<IOTDevice>();

        static void Main(string[] args)
        {
            Console.WriteLine("IOT devices monitoring is starting now...");

            InitializeDevice(5);  // Initialize 5 devices

            while (true)
            {
                foreach (var device in devices)
                {
                    device.GenerateData();
                    DisplayData(device);
                    CheckAlert(device);
                }

                Thread.Sleep(2000);  // 2-second delay to simulate real-time monitoring
            }
        }

        static void InitializeDevice(int numberOfDevices)
        {
            for (int i = 1; i <= numberOfDevices; i++)
            {
                devices.Add(new IOTDevice("Device" + i));  // Assign unique IDs to each device
            }
        }

        static void DisplayData(IOTDevice device)
        {
            Console.WriteLine($"Device ID: {device.DeviceID}, Temperature: {device.Temperature:F1}°C, Humidity: {device.Humidity:F1}%");
        }

        static void CheckAlert(IOTDevice device)
        {
            if (device.Temperature > 30)
            {
                Console.WriteLine($"ALERT! Device ID {device.DeviceID}: Temperature is too high - {device.Temperature:F1}°C");
            }
            else if (device.Humidity > 70)
            {
                Console.WriteLine($"ALERT! Device ID {device.DeviceID}: Humidity is too high - {device.Humidity:F1}%");
            }
            else
            {
                Console.WriteLine($"Device ID {device.DeviceID} is operating normally.");
            }
        }
    }
}
