using System;


namespace __Fundamentals.Day_4
{
    class ifElse
    {

        public void check_status(int num)
        {
            if(num<10)
            {
                Console.WriteLine("if block");
            } 
            else if (num<20)
            {
                if (num < 15) 
                    Console.WriteLine("nested else if block") ; 
                //you dont need {} if you only have one line of code after the if/else
                else
                    Console.WriteLine("nested else if block");
                Console.WriteLine("not nested because of the missing {}");
            } else
            {
                Console.WriteLine("else block");
            }

            
            Console.WriteLine("after");

            //shorthand, mostly used when assigning values

            
            string result = (num < 10) ? "lower than 10 short hand" : "greater than 10 short hand";

            //string result2 = (num < 10) ? (num<15)?"lower than 15 short hand" : "lower than 10 short hand" : "Other condition";

            Console.WriteLine(result);
        }

       
    }

    class SwitchCase
    {
        public SwitchCase(string dayOfWeek)
        {
            switch(dayOfWeek) 
            {
                case "monday":
                    Console.WriteLine("today is monday");
                    break; //exits the switch case - fall through, return will work as well
                case "tuesday":
                    Console.WriteLine("today is tuesday");
                    break;
                case "wednesday":
                    Console.WriteLine("today is wednesday");
                    break;
                case "thursday":
                    Console.WriteLine("today is thursday");
                    break;
                case "friday":
                    Console.WriteLine("today is friday");
                    break;
                case "saturday":
                    Console.WriteLine("today is saturday");
                    break;
                case "sunday":
                    Console.WriteLine("today is sunday");
                    break;
                default:
                    Console.WriteLine("please give a valid input");
                    break;


            }

            switch (dayOfWeek) //fallthrough
            {
                case "monday":
                    
                case "tuesday":
                    
                case "wednesday":
                    
                case "thursday":
                    
                case "friday":
                    Console.WriteLine("is is a working day");
                    break;
                case "saturday":
                    Console.WriteLine("today is saturday");
                    goto case "sunday"; //goto
                    //break;v -> not needed
                case "sunday":
                    Console.WriteLine("today is sunday");
                    break;
                default:
                    Console.WriteLine("please give a valid input");
                    break;


            }
        }
    }

    class Arrays
    {
        public void days()
        {
            string[] arr = { "monday", "tuesday", "wednesday", "thursday", "friday", "saturday", "sunday" };
            Console.WriteLine(arr); //gives back the data Type: System.String[]
            Console.WriteLine(arr[0]); //gives the string on position 0 -> monday
            Console.WriteLine(arr.Length);//gives the length of the array

            //iterate over every member of the array
            foreach(string day in arr)
            {
                Console.WriteLine(day);
            }

            //multidimensional array - 2D array

            int[,] numbers = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            /*
             * 123
             * 456
             * 789
             */

            //multidimensional array - 3D or more: https://www.tutorialsteacher.com/csharp/csharp-multi-dimensional-array

            

        }
    }

           
    public class Program
    {
        public static void Main(string[] args)
        {
            // ifElse obj = new ifElse();
            //obj.check_status(12);

            //SwitchCase obj = new SwitchCase("tuesday");
            var day = new Arrays();
            day.days(); 

        }
    }
    
}
