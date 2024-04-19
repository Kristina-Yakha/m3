using System;

namespace C__Fundamentals.Day_5
{
    internal class ForLoop
    {
        public ForLoop()
        {
            for (int i=0; i<5;i++)
            {
                Console.WriteLine(i);
            }

            int i = 0;
            for (; ; )
            {
                if (i < 0) break;
                else
                {
                    Console.WriteLine(i);
                    i--;
                }
            }

            for ( int i = 0; i <5; ++i)
            {
                if ( i == 3)
                {
                    break;
                } else
                {
                    Console.WriteLine(i);
                }
                Console.WriteLine("in for-loop");
            }
            Console.WriteLine("out for-loop");

            for (int i = 0; i < 5; ++i)
            { 
                for (int j = 0; j < 2; j++)
                {
                    if (i == 3)
                    {
                        break; //only breaking the inner for-loop
                    }
                    else
                    {
                        Console.WriteLine(i);
                    }
                    Console.WriteLine("in inner for-loop");
                }
                Console.WriteLine("in outer for-loop");
            }
            Console.WriteLine("outside for-loop");

            for (int i = 0; i <5; ++i)
            {
                if (i == 3) continue; //skips an iteration of the loop
                Console.WriteLine(i);
            }
        }
    }

    internal class WhileAndDoWhile
    {
        internal class NestedLoops
        {
            public NestedLoops()
            {
                for (int I = 0; I<5; I++)
                {
                    Console.Write(I);
                    for (int j = 0; j<5; j++)
                    {
                        Console.WriteLine(j);
                    }
                }

                for (int i = 0, j = 0; i< 5 && j < 5; i++, j++)
                {
                    Console.WriteLine(j + i);
                }

                int i = 0;

                for (;i<5;)
                {
                    Console.WriteLine(i);
                    i++;
                }
            }
        }
        public WhileAndDoWhile()
        {
            int i = 0;
             while (i<5)
            {
                Console.WriteLine(i);
                i++;
            }
            int j = 0;

            do
            {
                Console.WriteLine(j);
                j++;

            } while (j < 5);

        }
    }
    class Program
    {
        public static void Main(string[] args)
        {
            ForLoop obj = new ForLoop();

        }
    }

}

