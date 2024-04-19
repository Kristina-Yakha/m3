using System;

namespace Collatz
{

    class CollatzConjecture
    {
        private int startNumber;
        public CollatzConjecture(int startNumber)
        {
            this.startNumber = startNumber;
        }


        public int calculateSteps()
        {
            int iterations = 0;

            if (startNumber <= 0) 
                throw new ArgumentOutOfRangeException("Invalid number. Please enter a positive number");
            else
            {
                while (startNumber > 1)
                {
                    iterations++;
                    startNumber = (startNumber % 2 == 0) ? startNumber / 2 : startNumber * 3 + 1;
                 }
                 return iterations;
            }
            

        }


    }

    class Program
    {
        static void Main(string[] args)
        {
            var coll = new CollatzConjecture(1);

            Console.WriteLine(coll.calculateSteps());
        }
    }

}