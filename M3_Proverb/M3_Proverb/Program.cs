using System;

public static class Proverb
{
    public static string[] Recite(string[] subjects)
    {
        string[] verses = new string[subjects.Length];

        for (int i = 0; i < subjects.Length; i++)
        {
            if (i == subjects.Length - 1) verses[verses.Length - 1] = $"And all for the want of a {subjects[0]}.";
            else verses[i] = $"For want of a {subjects[i]} the {subjects[i + 1]} was lost.";
        }
        return verses;
    }
}