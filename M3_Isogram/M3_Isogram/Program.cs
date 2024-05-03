using System;
using System.Diagnostics.Metrics;

public static class Isogram
{
    public static bool IsIsogram(string word)
    {
        word = word.ToLower();
        Char[] letters = word.ToCharArray();

        bool isIsogram = true;

        for (int i = 0; i < word.Length; i++)
        {

            if (Char.IsWhiteSpace(letters[i])) continue;
            else if (letters[i] == '-') continue;
            else
            {
                for (int j = 0; j<letters.Length; j++)
                {
                    if (letters[j] == letters[i] && j != i) isIsogram = false;
                 
                }
                
            }
            
        }
        return isIsogram;

    }

    public static void Main(string[] args)
    {
        Console.WriteLine(IsIsogram("isogram"));
    }
}
