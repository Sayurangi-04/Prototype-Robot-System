using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robotic_Factory_System
{
    public class EntertainmentRobot : Robot
    {
        public string EntertainmentFeature { get; set; }

        public EntertainmentRobot(string modelName, double batteryCapacity,
                                   string softwareVersion,
                                   string entertainmentFeature)
            : base(modelName, batteryCapacity, softwareVersion)
        {
            EntertainmentFeature = entertainmentFeature;
        }

        public override Robot Clone()
        {
            return new EntertainmentRobot(
                ModelName,
                BatteryCapacity,
                SoftwareVersion,
                EntertainmentFeature
            );
        }

        public override void DisplayDetails()
        {
            Console.WriteLine("----- Entertainment Robot -----");
            Console.WriteLine("Model Name: " + ModelName);
            Console.WriteLine("Battery Capacity: " + BatteryCapacity + " hours");
            Console.WriteLine("Software Version: " + SoftwareVersion);
            Console.WriteLine("Entertainment Feature: " + EntertainmentFeature);
        }
    }
}
