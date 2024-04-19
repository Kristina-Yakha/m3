using System;

namespace C__Fundamentals.Day_3
{
	internal class enumerations
	{
		enum jobLevel
		{
			JL1 = 1000, //0 -> if the JL1 is given a value, the variables after will be iterated as well
			JL2, //1
			JL3 //2 -> originally int, so you cannot type cast string to it
		}

		public static void Main(string[] args)
		{
			jobLevels obj1 = jobLevel.JL1; //assignes JL1
			int obj2 = (int) jobLevel.JL1; //unless you convert it to a data type (int,..) the constant name in the enum will be assigned
			int obj3 = (int)jobLevel.JL3;
			Console.WriteLine(obj1); //prints out JL1
			Console.WriteLine(obj2); //prints 1001
            Console.WriteLine(obj3); //prints 1002
        }
}

