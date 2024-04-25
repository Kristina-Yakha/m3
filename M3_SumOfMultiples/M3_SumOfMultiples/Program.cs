using System;
using System.Collections.Generic;


public static class SumOfMultiples
{

    public static int Sum(IEnumerable<int> multiples, int max)
    {

        List<int> uniqueMultiples = new List<int>();
        //the number that is to be
        int newListItem = 0;
        int sum = 0;


        foreach (int multiple in multiples)
        {

            int factor = 0;
            if (multiple != 0) factor = (int)((max - 1) / multiple);

            while (factor > 0)
            {

                //calculate multiple
                newListItem = multiple * factor;

                //if number does not exist in the List, add number
                if (!uniqueMultiples.Contains(newListItem)) uniqueMultiples.Add(newListItem);

                factor--;

            }
        }

        //iterate through the list and sum the multiples

        foreach (int uniqueMultiple in uniqueMultiples)
        {
            sum += uniqueMultiple;
        }
        return sum;
    }
}

