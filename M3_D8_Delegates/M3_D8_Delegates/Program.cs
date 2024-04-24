using System;
using System.Text.RegularExpressions;
using System.Xml.Schema;

namespace M3_D8_Delegates
{
    /*
    delegate void Operation(int num1, int num2);
    internal class Delegates
    {
        public static void Add (int a, int b)
        {
            Console.WriteLine($"Addition result: {a + b}");

        }
        public static void Add(double a, double b)
        {
            Console.WriteLine($"Addition result of 3 parameters: {a + b}");

        }
        public static void Subtract(int a, int b)
        {
            Console.WriteLine($"Addition result: {a - b}");

        }
    }
    class Program
    {
        public static void Main(string[] args)
        {
            //creating the instance of the delegate
            Operation addition = Delegates.Add;
            Operation substraction = Delegates.Subtract;

            //invoking the instances
            //no overloading possible

            addition(10, 5);
            substraction(10, 5);
            
        }
    }
    */
    /*
    namespace M3_D8_Events
    {
        internal class Events
        {
            //declare a delegate for out event
            public delegate void ClickEventHandler();

            //define the event and this event is of the delegate type that we declared 
            public static event ClickEventHandler Click;

            //method to simulate button click
            public static void SimulateClick()
            {
                Console.WriteLine("button clicked");
                OnClick();//invokes the click
            }

            //method to raise the button clicked event
            public static void OnClick()
            {
                //emulates the click, the Subscriber
                Click?.Invoke();
            }
        }
       class EventHandlerClass
        {
            public static void ButtonClickHandler()
            {
                Console.WriteLine("botton click event handled");
            }
        }

        class Program
        {
            public static void Main(string[]args)
            {
                Events.Click += EventHandlerClass.ButtonClickHandler;
                Events.SimulateClick();
            }
        }
    }
    */

    internal class RegexClass
    {
        static string pattern = "a+.e?";

        public static void Main(string[] args)
        {
            Regex regex = new Regex(pattern);

            if(regex.IsMatch("apple"))
            {
                Console.WriteLine("string matches");
            } else
            {
                Console.WriteLine("string does not match");
            }
        }
    }
}