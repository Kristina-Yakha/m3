using System;
using System.Text.RegularExpressions;

public static class Identifier
{
    public static string Clean(string identifier)
    {
        //identifier= identifier.Replace(' ', '_');

        char[] chars = identifier.ToCharArray();



        int controlIndex = 0;

        while (controlIndex < chars.Length)
        {

            if (chars[controlIndex] == ' ')
            {
                identifier = identifier.Replace(Char.ToString(chars[controlIndex]), "_");
            }
            //replace control characers with upper case string "CTRL"

            else if (char.IsControl(chars[controlIndex]))
            {
                identifier = identifier.Replace(Char.ToString(chars[controlIndex]), "CTRL");
            }

            //Convert Kebab_Case to camelCase

            else if (chars[controlIndex] == '-')
            {
                string kebab = Char.ToString(Char.ToUpper(chars[controlIndex + 1]));
                identifier = identifier.Replace(("-" + Char.ToString(chars[controlIndex + 1])), kebab);
            }

            //Omit Characters that are not letters

            else if (!char.IsLetter(chars[controlIndex]))
            {
                identifier = identifier.Replace(Char.ToString(chars[controlIndex]), "");

            }
            controlIndex++;
        }

        //Task 5 Greek lower case letters with Regex

        string pattern = @"[α-ω]+";

        identifier = Regex.Replace(identifier, pattern, "");

        return identifier;


    }
}
