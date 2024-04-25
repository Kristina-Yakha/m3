using System;

public static class Pangram
{
    public static bool IsPangram(string input)
    {
        char[] letters = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };

        input = input.ToLower();

        char[] sentence = input.ToCharArray();

        bool hasLetter = false;


        for (int i = 0; i < letters.Length; i++)
        {
            hasLetter = false;
            for (int j = 0; j < sentence.Length; j++)
            {
                if (letters[i] == sentence[j])
                {
                    hasLetter = true;
                }
            }

            if (!hasLetter) break;



        }

        return hasLetter;

    }
}
