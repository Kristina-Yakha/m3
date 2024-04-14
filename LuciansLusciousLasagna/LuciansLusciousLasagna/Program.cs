using System;
using System.Net;
using System.Runtime.InteropServices;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Lasagna
{
    class Program
    {
        public static void Main(string[] args) {

            var lasagna = new Lasagna();
            int bakingTime;
            int numLayers;

            Console.WriteLine("How long has your lasagna been baking?");
            bakingTime = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("How many layers does your lasagna have?");
            numLayers = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("The lasagna needs to be " + lasagna.ExpectedMinutesInOven()+ " minutes in the oven.");
            Console.WriteLine("The lasagna has been " + lasagna.RemainingMinutesInOven(bakingTime)+ " minutes in the oven");
            Console.WriteLine("You have preparated the lasagna for " + lasagna.PreparationTimeInMinutes(numLayers) + " minutes");
            Console.WriteLine("You have been cooking the lasagna for " + lasagna.ElapsedTimeInMinutes(numLayers, lasagna.RemainingMinutesInOven(10)) + " minutes"); ;
        }
        class Lasagna()
        {
            //Define the Lasagna.ExpectedMinutesInOven() method that does not take any parameters and 
            //returns how many minutes the lasagna should be in the oven.
            //According to the cooking book, the expected oven time in minutes is 40:
            public int ExpectedMinutesInOven()
            {
                int minutes = 40;
                return minutes;
            }

            //Define the Lasagna.RemainingMinutesInOven() method that 
            //takes the actual minutes the lasagna has been in the oven as a parameter and 
            //returns how many minutes the lasagna still has to remain in the oven, 
            //based on the expected oven time in minutes from the previous task.

            public int RemainingMinutesInOven(int minutes) 
            {

                int expectedTime = ExpectedMinutesInOven() - minutes;
                return expectedTime;
            }

            //Define the Lasagna.PreparationTimeInMinutes() method that 
            //takes the number of layers you added to the lasagna as a parameter and 
            //returns how many minutes you spent preparing the lasagna, assuming each layer takes you 2 minutes to prepare.

            public int PreparationTimeInMinutes(int layers)
            {
               int elapsedTime = layers * 2;
               return elapsedTime;
            }

            //Define the Lasagna.ElapsedTimeInMinutes() method that takes
            //two parameters: the first parameter is the number of layers you added to the lasagna, and
            //the second parameter is the number of minutes the lasagna has been in the oven.
            //The function should return how many minutes you've worked on cooking the lasagna,
            //which is the sum of the preparation time in minutes, and the time in minutes the lasagna has spent in the oven at the moment.

            public int ElapsedTimeInMinutes(int layers, int minutes) 
            {
                int elapsedTime = PreparationTimeInMinutes(layers) + minutes;
                return elapsedTime;
            }
        }

        
    }
}
