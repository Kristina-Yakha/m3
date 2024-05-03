using System;
using System.Text.RegularExpressions;

public static class Acronym
{
    public static string Abbreviate(string phrase)
    {
        phrase = Regex.Replace(phrase, @"\s*-+\s*|\s*_+\s*", " ");
        string[] splitPhrase = phrase.Split(' ');
        string acronym = "";

        foreach (string word in splitPhrase)
        {
            acronym += word.Substring(0, 1);
        }
        return acronym.ToUpper();
    }
}