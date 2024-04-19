using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

public static class Series
{
    //Output all the contiguous substrings of length n in that string in the order that they appear.
    //Each substring is in the array Slices[]



    public static string[] Slices(string numbers, int sliceLength)
    {
        //länge des arrays berechnen

        int numSlices = numbers.Length - sliceLength + 1;

        //instanciates array with calculated length
        string[] slices = new string[numSlices];

        for (int i = 0; i< numSlices;i++)
        {
            string slice = numbers.Substring(i, sliceLength);
            slices[i] = slice;
            //Console.WriteLine(slice + " ");
        }
          
        return slices;
      
    }

    public static void Main(string[] args)
    {

        string[] slices = Slices("12345", 3);
        foreach(string slice in slices)
        {
            Console.WriteLine(slice);
        }
    }
        
}


