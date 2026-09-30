using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robotic_Factory_System
{
    public class IndustrialRobot : Robot
    {
        public string IndustrialTask { get; set; }

        public IndustrialRobot(string modelName, double batteryCapacity,
                               string softwareVersion, string industrialTask)
            : base(modelName, batteryCapacity, softwareVersion)
        {
            IndustrialTask = industrialTask;
        }

        public override Robot Clone()
        {
            return new IndustrialRobot(
                ModelName,
                BatteryCapacity,
                SoftwareVersion,
                IndustrialTask
            );
        }

        public override void DisplayDetails()
        {
            Console.WriteLine("----- Industrial Robot -----");
            Console.WriteLine("Model Name: " + ModelName);
            Console.WriteLine("Battery Capacity: " + BatteryCapacity + " hours");
            Console.WriteLine("Software Version: " + SoftwareVersion);
            Console.WriteLine("Industrial Task: " + IndustrialTask);
        }
    }
}