using System;

namespace M3_D6_TypeCasting
{
    internal class TypeCasting
    {

        //static double numD = 9.24; 
        //static int numI = (int)numD; Explicit type conversion cannot be done outside of a method -> Exception if the variable is static
        public void ImplicitCasting()
        {
            int num = 9;
            double numD = num; //implicit type conversion
            if (num == numD) //enters the if block because the bit code assigned to the numbers is still the same.
            {
                Console.WriteLine("inside if block");
            }
            Console.WriteLine(num);
            Console.WriteLine(numD);
        }

        public void ExplicitCasting()
        {
            double numD = 9.99; //you cannot implicitly convert a bigger data type to a smaller data type
            int numI = (int)numD;
            Console.WriteLine(numI);
            Console.WriteLine(numD);

            //Careful of data loss

        }

        public void Parsing() //you cannot convert a double into an int using parsing, the exact format has to be used!
        {
            string numS = "10.5";
            bool success = int.TryParse(numS, out int numI);

            Console.WriteLine(success);
            //int numI = int.Parse(numS);
            Console.WriteLine(numI);
            double numD = double.Parse(numS);
            Console.WriteLine(numD);
        }

        public void ConvertClass()
        {
            string numI = "10";
            //int numI = Convert.ToInt32(numS);
            double numD = 10.25;
            bool myBool = true;
            string boolS  = "true";
            Console.WriteLine(Convert.ToString(numI));
            Console.WriteLine(Convert.ToDouble(numI));
            Console.WriteLine(Convert.ToInt32(numD)); //data loss
            Console.WriteLine(Convert.ToString(myBool));
            Console.WriteLine(Convert.ToBoolean(boolS));    

        }

        class ArrayOperations
        {
            public void copyArray()
            {
                int[] myintegers = { 1, 2, 3, 4, 5 }; //declaration and definition
                int[] myIntegers2 = new int[10]; // defining the array
                myintegers.CopyTo(myIntegers2,2);
                // 0 ->  index in the array in which the coyping begins
                // -> the destination hast to be long  enough to contain the original array
                // only the values on the assigned positions are overwritten, the rest remains the same
                Array.Reverse(myIntegers2, 0, 10); //reverses the array
                Array.Sort(myIntegers2); //sorts the array
                foreach (int i in myIntegers2) {
                    Console.Write(i);
                }

                Console.WriteLine(Array.IndexOf(myintegers, 4)); //gives you the first encountered value, then terminates

            }
        }
        
        internal class Methods
        {

            //you cannot do method overloading based on the return type (void, int, etc.)
            public void add(int a, int b)
            {
                Console.WriteLine(a + b);
            }

            public double add (double a, double b)
            {
                return a + b;
            }

            public double add (double a, double b, double c)
            {
                return a+b+c;
            }

            public void myMethod (string name = "Mathilde") //default value, when no parameter is 
            {
                Console.WriteLine (name);
            }
        }

        internal class Recursion
        {
            //4!= $*3*2*1
            public int factorial(int n)
            {
                if (n > 1)
                    return n * factorial(n - 1);
                else return n;
               
            }

            public int factorialWithoutRecursion (int n)
            {
                /*
                int i = n-1;
                while (i > 1)
                {
                    n *= i;
                    i--;
                }
                return n;
                */
                int i = n;
                do
                {
                    
                    if (n == 1) return n;
                    else
                    {
                        n *= --i;
                    } 
                } while (i > 1);
                return n;
            }

            
            
        }


        public static void Main(string[] args)
        {
            // TypeCasting obj = new TypeCasting();
            //obj.ConvertClass();
            /*
            ArrayOperations obj = new ArrayOperations();
            obj.copyArray();
            Methods m = new Methods();
            m.myMethod();
            m.myMethod("Anna");*/

            Recursion obj = new Recursion();
            Console.WriteLine(obj.factorial(4));
            Console.WriteLine(obj.factorialWithoutRecursion(4));
        }
    }
}
