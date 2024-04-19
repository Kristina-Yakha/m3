using System;

public static class Hamming
{
    public static int Distance(string firstStrand, string secondStrand)
    {
        int distance = 0;
        char[] firstStrandArr = firstStrand.ToCharArray();
        char[] secondStrandArr = secondStrand.ToCharArray();


        if (firstStrand.Length != secondStrand.Length)
        {

            throw new ArgumentException("The Strands do not have the same length");

        }
        else
        {
            for (int i = 0; i < firstStrandArr.Length; i++)
            {
                if (firstStrandArr[i] != secondStrandArr[i])
                    distance++;
            }

            return distance;
        }

    }
}