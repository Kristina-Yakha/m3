using System;
using System.Globalization;
//CultureInfo.CurrentCulture = new CultureInfo("en-US"); add after any other using statements


namespace M3_D6_MicrosoftLearingExercises
{
    

    class Datatypes
    { 
        public static void SignedIntegralTypes()
        {
            Console.WriteLine("");
            Console.WriteLine("Signed integral types:");
            Console.WriteLine($"sbyte  : {sbyte.MinValue} to {sbyte.MaxValue}");
            Console.WriteLine($"short  : {short.MinValue} to {short.MaxValue}");
            Console.WriteLine($"int    : {int.MinValue} to {int.MaxValue}");
            Console.WriteLine($"long   : {long.MinValue} to {long.MaxValue}");
        }
        public static void UnsignedIntegralTypes()
        {
            Console.WriteLine("");
            Console.WriteLine("Unsigned integral types:");
            Console.WriteLine($"byte   : {byte.MinValue} to {byte.MaxValue}");
            Console.WriteLine($"ushort : {ushort.MinValue} to {ushort.MaxValue}");
            Console.WriteLine($"uint   : {uint.MinValue} to {uint.MaxValue}");
            Console.WriteLine($"ulong  : {ulong.MinValue} to {ulong.MaxValue}");
        }

        public static void FloatingPointTypes()
        {
            Console.WriteLine("");
            Console.WriteLine("Floating point types:");
            Console.WriteLine($"float  : {float.MinValue} to {float.MaxValue} (with ~6-9 digits of precision)");
            Console.WriteLine($"double : {double.MinValue} to {double.MaxValue} (with ~15-17 digits of precision)");
            Console.WriteLine($"decimal: {decimal.MinValue} to {decimal.MaxValue} (with 28-29 digits of precision)");
        }

        public static void ReferenceTypes()
        {
            //When ref_B = ref_A is executed, ref_B points to the same memory location as ref_A.
            //So, when ref_B[0] is changed, ref_A[0] also changes. 
            int[] ref_A = new int[1];
            ref_A[0] = 2;
            int[] ref_B = ref_A;
            ref_B[0] = 5;

            Console.WriteLine("--Reference Types--");
            Console.WriteLine($"ref_A[0]: {ref_A[0]}");
            Console.WriteLine($"ref_B[0]: {ref_B[0]}");
        }
    }

    class DataTypeConversion
    {
        public void dataConversion()
        {

            //widening conversion:
            //converting a value from a data type that could hold less information to
            //a data type that can hold more information. 
            /*
            int myInt = 3;
            Console.WriteLine($"int: {myInt}");

            decimal myDecimal = myInt;
            Console.WriteLine($"decimal: {myDecimal}");*/

            //Performing a cast /Explicit conversion
            //Data loss possible
            //narrowing conversion: Convert value from a data type that holds more information
            //to a data type that holds less information
            /*
            decimal myDecimal = 3.14m;
            Console.WriteLine($"decimal: {myDecimal}");

            int myInt = (int)myDecimal;
            Console.WriteLine($"int: {myInt}");*/

            //Data Conversion with ToString()

            /*
            int first = 5;
            int second = 7;
            string message = first.ToString() + second.ToString();
            Console.WriteLine(message); */

            // Data Conversion with Parse()
            /*
            string first = "5";
            string second = "7";
            int sum = int.Parse(first) + int.Parse(second);
            Console.WriteLine(sum);*/

            //Data Conversion with Convert

            /*
            string value1 = "5";
            string value2 = "7";
            int result = Convert.ToInt32(value1) * Convert.ToInt32(value2);
            Console.WriteLine(result);*/
            /*
            int value = (int)1.5m; // casting truncates
            Console.WriteLine(value);

            int value2 = Convert.ToInt32(1.5m); // converting rounds up
            Console.WriteLine(value2);*/

            /* Try Parse() */

            string value = "hi";
            int result = 2;
            if (int.TryParse(value, out result))
            {
                Console.WriteLine($"Measurement: {result}");
            }
            else
            {
                Console.WriteLine("Unable to report the measurement.");
            }
            if (result > 0)
                Console.WriteLine($"Measurement (w/ offset): {50 + result}");
        }
    }
    
    class Program
    {

        public static void Main(string[] args)
        {
            /******** data type conversion*****/
           // DataTypeConversion data = new DataTypeConversion();
            //data.dataConversion();

            /**************datatypes********/
            /**
            Datatypes obj = new Datatypes();
            Datatypes.UnsignedIntegralTypes();
            Datatypes.SignedIntegralTypes();
            Datatypes.FloatingPointTypes();
            Datatypes.ReferenceTypes();
            **/


        }
        
    } 
}
