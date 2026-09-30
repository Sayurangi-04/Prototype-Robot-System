using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robotic_Factory_System
{
    public class ServiceRobot : Robot
    {
        public string ServiceTask { get; set; }

        public ServiceRobot(string modelName, double batteryCapacity,
                            string softwareVersion, string serviceTask)
            : base(modelName, batteryCapacity, softwareVersion)
        {
            ServiceTask = serviceTask;
        }

        public override Robot Clone()
        {
            return new ServiceRobot(
                ModelName,
                BatteryCapacity,
                SoftwareVersion,
                ServiceTask
            );
        }

        public override void DisplayDetails()
        {
            Console.WriteLine("----- Service Robot -----");
            Console.WriteLine("Model Name: " + ModelName);
            Console.WriteLine("Battery Capacity: " + BatteryCapacity + " hours");
            Console.WriteLine("Software Version: " + SoftwareVersion);
            Console.WriteLine("Service Task: " + ServiceTask);
        }
    }
}
