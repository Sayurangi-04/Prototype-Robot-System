using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robotic_Factory_System
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ServiceRobot serviceRobot = new ServiceRobot("ServiceBot S1",10,"v1.0","Patient Assistance");

            Console.WriteLine("ORIGINAL SERVICE ROBOT");
            serviceRobot.DisplayDetails();

            ServiceRobot serviceClone =
                (ServiceRobot)serviceRobot.Clone();

            serviceClone.BatteryCapacity = 15;
            serviceClone.SoftwareVersion = "v2.0";

            Console.WriteLine("\nCLONED SERVICE ROBOT");
            serviceClone.DisplayDetails();


            IndustrialRobot industrialRobot = new IndustrialRobot("IndustrialBot I1",12,"v1.5","Welding");

            Console.WriteLine("\nORIGINAL INDUSTRIAL ROBOT");
            industrialRobot.DisplayDetails();

            IndustrialRobot industrialClone =
                (IndustrialRobot)industrialRobot.Clone();

            industrialClone.BatteryCapacity = 18;
            industrialClone.SoftwareVersion = "v2.0";

            Console.WriteLine("\nCLONED INDUSTRIAL ROBOT");
            industrialClone.DisplayDetails();


            EntertainmentRobot entertainmentRobot =
                new EntertainmentRobot("EntertainmentBot E1", 8, "v1.2","Dancing and Talking");

            Console.WriteLine("\nORIGINAL ENTERTAINMENT ROBOT");
            entertainmentRobot.DisplayDetails();

            EntertainmentRobot entertainmentClone =
                (EntertainmentRobot)entertainmentRobot.Clone();

            entertainmentClone.BatteryCapacity = 12;
            entertainmentClone.SoftwareVersion = "v2.0";

            Console.WriteLine("\nCLONED ENTERTAINMENT ROBOT");
            entertainmentClone.DisplayDetails();

            Console.ReadLine();
        }
    }
}
