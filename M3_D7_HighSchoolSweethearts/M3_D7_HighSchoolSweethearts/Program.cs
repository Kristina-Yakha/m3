using System;
using System.Globalization;

public static class HighSchoolSweethearts
{
    public static string DisplaySingleLine(string studentA, string studentB)
    {
        return $"{studentA,29} ♡ {studentB,-29}";
    }

    private static string getInitials(string name)
    {
        return $"{name.Substring(0, 1)}. {name.Substring(name.IndexOf(" ") + 1, 1)}.";
    }


    public static string DisplayBanner(string studentA, string studentB)
    {
        studentA = getInitials(studentA);
        studentB = getInitials(studentB);

        string heart = "     ******       ******\n" +
                       "   **      **   **      **\n" +
                       " **         ** **         **\n" +
                       "**            *            **\n" +
                       "**                         **\n" +
                       "**     {0}  +  {1}     **\n" +
                       " **                       **\n" +
                       "   **                   **\n" +
                       "     **               **\n" +
                       "       **           **\n" +
                       "         **       **\n" +
                       "           **   **\n " +
                       "            ***\n" +
                       "              *";

        return String.Format(heart, studentA, studentB);

    }

    public static string DisplayGermanExchangeStudents(string studentA
        , string studentB, DateTime start, float hours)
    {

        CultureInfo de = CultureInfo.CreateSpecificCulture("de-DE"); //start.ToString(de)
        DateTimeFormatInfo dtfi = de.DateTimeFormat;
        string startTime = start.ToString("d", dtfi);
        string strHours = hours.ToString("N2", de);


        return $"{studentA} and {studentB} have been dating since {startTime} - that's {strHours} hours";

    }
}






















