using System;

public static class ReverseString
{
    public static string Reverse(string input)
    {
        char[] inputString = input.ToCharArray();
        string reverseString = "";

        for (int i = inputString.Length - 1; i >= 0; i--)
        {
            reverseString += inputString[i].ToString();
        }
        return reverseString;

    }
}