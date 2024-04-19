using System;
using System.Runtime.ConstrainedExecution;
using static System.Net.Mime.MediaTypeNames;

namespace WindowsChallenge
{

    class Program
    {
        public static void Main(string[] args)
        {

            /******************************************
             * 
             * Correct the code and make it more readable, If-Else
             
            int[] numbers = { 4, 8, 15, 16, 23, 42 };
            bool found = false;
            int total = 0;

            foreach (int number in numbers)
            {
                total += number;
                if (number == 42) 
                    found = true;
            }

            if (found) 
                Console.WriteLine("Set contains 42");
           
            Console.WriteLine($"Total: {total}");

            *****************************************/

            //Rewrite Code to a Switch Statement

            /************************************************

            // SKU = Stock Keeping Unit. 
            // SKU value format: <product #>-<2-letter color code>-<size code>


            string sku = "01-MN-L";

            string[] product = sku.Split('-');

            string type = "";
            string color = "";
            string size = "";


            switch (product[0])
            {
                case "01":
                    type = "Sweat shirt";
                    break;
                case "02":
                    type = "T-shirt";
                    break;
                case "03":
                    type = "Sweat pants";
                    break;
                default:
                    type = "Other";
                    break;
            }

            switch (product[1])
            {
                case "BL":
                    color = "Black";
                    break;
                case "MN":
                    color = "Maroon";
                    break;
                default:
                    color = "White";
                    break;

            }


            switch (product[2])
            {
                case "S":
                    size = "Small";
                    break;
                case "M":
                    size = "Medium";
                    break;
                case "L":
                    size = "Large";
                    break;
                default:
                    color = "One Size fits all";
                    break;

            }
         

            Console.WriteLine($"Product: {size} {color} {type}");

            ***************************************************************/

            //FizzBuzz Challenge - For-Loops

            //Output values from 1 to 100, one number per line, inside the code block of an iteration statement.
            //When the current value is divisible by 3, print the term Fizz next to the number.
            //When the current value is divisible by 5, print the term Buzz next to the number.
            //When the current value is divisible by both 3 and 5, print the term FizzBuzz next to the number.

            /********************************

            for (int i = 0; i <= 100; i++)
            {
                string fizzBuzz = "";
                if (i % 3 ==0) fizzBuzz = "Fizz";
                if (i % 5 == 0) fizzBuzz = fizzBuzz + "Buzz";

                
                if (fizzBuzz != "") fizzBuzz = $" - {fizzBuzz}";
                
                Console.WriteLine(i + fizzBuzz);
                
            }

            **************************************/

            
           

        }

    }

}
