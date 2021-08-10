using System;
using System.Collections.Generic;

namespace FT
{
    public struct deviceSettings{

        public string serial{get; set;}
        public int interval{get; set;}
        public int count{get; set;}
        public int battery{get; set;}
        public DateTime startAt{get; set;}

        public deviceSettings(string serial, int interval, int count, int battery, DateTime startAt){
            this.serial = serial;
            this.interval = interval;
            this.count = count;
            this.battery = battery;
            this.startAt = startAt;
        }

        public void showSettings(){
            Console.WriteLine(this.serial);
            Console.WriteLine(this.interval);
            Console.WriteLine(this.count);
            Console.WriteLine(this.battery);
            Console.WriteLine(this.startAt);
        }

        public override string ToString() => $"({this.serial}, {this.startAt})";
    }



    class Program
    {
        static void Main(string[] args)
        {
            deviceSettings device = new deviceSettings("A1B2C3", 10, 10, 100, DateTime.Now);
            device.count = 100;
            Console.WriteLine(device.ToString());
            device.showSettings();
        }
    }
}
