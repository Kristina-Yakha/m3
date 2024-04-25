using System;
using System.Collections.Generic;

public static class Languages
{
    public static List<string> NewList()
    {
        //Create a new empty list
        List<string> newList = new List<string>();
        return newList;
    }

    public static List<string> GetExistingLanguages()
    {
        //Define an existing list

        List<string> existingLanguages = NewList();
        existingLanguages.Add("C#");
        existingLanguages.Add("Clojure");
        existingLanguages.Add("Elm");

        return existingLanguages;

    }

    public static List<string> AddLanguage(List<string> languages, string language)
    { //Add a new language to an existing list
        languages.Add(language);
        return languages;
    }

    public static int CountLanguages(List<string> languages)
    { //Count the languages in the list
        return languages.Count;
    }

    public static bool HasLanguage(List<string> languages, string language)
    { //Check to see if a language is in the list
        return (languages.Contains(language));
    }

    public static List<string> ReverseList(List<string> languages)
    {
        //Reverse the list
        languages.Reverse();
        return languages;
    }

    public static bool IsExciting(List<string> languages)
    {
        //The first on the list is C#.
        //  The second item on the list is C# and the list contains either two or three languages.
        if (languages.Count > 0)
        {
            if (languages[0] == "C#") return true;
            else if ((languages[1] == "C#") && (languages.Count == 2 || languages.Count == 3)) return true;
            else return false;

        }
        else
        {
            return false;
        }

    }

    public static List<string> RemoveLanguage(List<string> languages, string language)
    {
        //Remove a language
        languages.Remove(language);
        return languages;

    }

    public static bool IsUnique(List<string> languages)
    {
        bool isUnique = true;

        //does the list contain duplicates?

        for (int i = 0; i < languages.Count; i++)
        {
            for (int j = 0; j < languages.Count; j++)
            {
                //if two items have the same value but are not on the same position in the list
                if ((languages[i] == languages[j]) && (i != j))
                {
                    isUnique = false;
                }
            }
        }
        return isUnique;
    }
}










