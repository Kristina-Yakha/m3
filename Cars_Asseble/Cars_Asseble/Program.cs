using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CarsAssemble
{
   class Program
    {
        public static void Main(string[] args)
        {
            var AssemblyLine = new AssemblyLine();

            Console.Write("Speed setting: ");
            int speed = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Success rate: " + AssemblyLine.SuccessRate(speed));
            Console.WriteLine("Production Rate: " + AssemblyLine.ProductionRatePerHour(speed));
            Console.WriteLine("Cars produced per minute: " + AssemblyLine.WorkingItemsPerMinute(speed));
        }
    }

    class AssemblyLine
    {

        //Implement the(static) AssemblyLine.SuccessRate() method to
        //calculate the ratio of an item being created without error for a given speed.
        //The following table shows how speed influences the success rate:
        //0: 0% success rate.
        //1 to 4: 100% success rate.
        //5 to 8: 90% success rate.
        //9: 80% success rate.
        //10: 77% success rate.

        public static double SuccessRate(int speed)
        {

            double successRate = 0;

            if (speed == 0) {

                successRate = 0;

            } else if (speed < 5)
            {
                successRate = 1.0;

            } else if ((speed >= 5) && (speed <9))
            {
                successRate = 0.9;

            } else if (speed == 9)
            {
                successRate = 0.8;

            } else if (speed == 10)
            {
                successRate = 0.77;
            }

            return successRate;

        }

        //Implement the (static) AssemblyLine.ProductionRatePerHour() method to
        //calculate the assembly line's production rate per hour,
        //taking into account its success rate:

        public static double ProductionRatePerHour(int speed)
        {
            double productionRate = 0;
            double carsPerHour = speed * 221;

            productionRate = carsPerHour * SuccessRate(speed);

            return productionRate;
        }

        //Implement the (static) AssemblyLine.WorkingItemsPerMinute() method
        //to calculate how many working cars are produced per minute:

        public static int WorkingItemsPerMinute(int speed)
        {
            int itemsPerMinute = 0;
            //double successRate = SuccessRate(speed);
            double productionRatePerHour = ProductionRatePerHour(speed);

            itemsPerMinute = (int)productionRatePerHour / 60;


            return itemsPerMinute;
        }
    }
}
