using System;

class Program
{
    class Foul{
        
        public string Message()
        {
            return "hello";
        }



    }

    public static void Main(string[] args)
    {
        Foul foul = new Foul();
        Console.WriteLine(foul.GetType());
        Console.WriteLine(foul.Message());
        Console.WriteLine(typeof(Foul)); 


        
        

    }
}