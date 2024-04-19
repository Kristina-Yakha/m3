using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

public static class Series
{
    //Output all the contiguous substrings of length n in that string in the order that they appear.
    //Each substring is in the array Slices[]



    public static string[] Slices(string numbers, int sliceLength)
    {
        //calculates number of slices  

        int numSlices = numbers.Length - sliceLength + 1;

        if (sliceLength <= 0 || numSlices <= 0) throw new ArgumentException("Input invalid.");
        else
        {
            //creates array with length equal to the number of slices
            string[] slices = new string[numSlices];
            //takes the Substring with the sliceLength and puts it in the array
            for (int i = 0; i < numSlices; i++)
            {
                string slice = numbers.Substring(i, sliceLength);
                slices[i] = slice;
                //Console.WriteLine(slice + " ");
            }

            return slices;
        }



    }

    public static void Main(string[] args)
    {

        string[] slices = Slices("12345", 3);
        foreach (string slice in slices)
        {
            Console.WriteLine(slice);
        }
    }

}
