using System;

namespace M3_D6_Datatypes_Coding_Challenge {

class BusinessLogic
    {
        public void businessLogic()
        {
            //To instantiate a string array, enter the following "starter" code:
            string[] values = { "12,3", "45", "ABC", "11", "DEF" };

            //Create a looping structure that can be used to iterate through each string value in the array values.

            string message = "";
            double total = 0;

            foreach (string value in values)
            {
                //Rule 1: If the value is alphabetical, concatenate it to form a message.
                //Rule 2: If the value is numeric, add it to the total.

                double number = 0;
                if (double.TryParse(value, out number))
                {
                    total += number;
                    Console.WriteLine((double)total);
                } else
                {
                    message += value;
                }

               


            }

            Console.WriteLine($"Message: {message}");
            Console.WriteLine($"Total: {total}");


        }

        public void BusinessLogic2()
        {
            int value1 = 11;
            decimal value2 = 6.2m;
            float value3 = 4.3f;

            // Your code here to set result1
            // Hint: You need to round the result to nearest integer (don't just truncate)

            decimal result1 = value1 / value2;

            Console.WriteLine($"Divide value1 by value2, display the result as an int: {Convert.ToInt32(result1)}");

            decimal result2 = value2 / (decimal)value3; 

            // Your code here to set result2
            Console.WriteLine($"Divide value2 by value3, display the result as a decimal: {result2}");

            float result3 = value3 / value1;
            // Your code here to set result3
            Console.WriteLine($"Divide value3 by value1, display the result as a float: {result3}");
        }

    }
class Program
    {
        static void Main(string[] args)
        {
            BusinessLogic log = new BusinessLogic();
            log.BusinessLogic2();
        }
    }

}
