using System;
using System.Text.RegularExpressions;

public class LogParser
{
    public bool IsValidLine(string text)
    {
        string pattern = @"^\[(TRC|DBG|INF|WRN|ERR|FTL)\]";

        return Regex.IsMatch(text, pattern);

    }

    public string[] SplitLogLine(string text)
    {
        Regex regex = new Regex(@"<[\*^=-]*>");
        return regex.Split(text);

    }



    public int CountQuotedPasswords(string lines)
    {
        int count = 0;

        string pattern = @"""[\s\w]*password[\s\w]*""";

        Match match = Regex.Match(lines, pattern, RegexOptions.IgnoreCase | RegexOptions.Multiline);

        while (match.Success)
        {
            count++;
            match = match.NextMatch();
        }

        return count;

    }

    public string RemoveEndOfLineText(string line)
    {
        string pattern = @"end-of-line\d+";

        return Regex.Replace(line, pattern, "");

    }

    public string[] ListLinesWithPasswords(string[] lines)
    {

        string pattern = @"password\w+";

        for (int i = 0; i < lines.Length; i++)
        {

            string[] arr = lines[i].Split(" ");

            Match match = Regex.Match(lines[i], pattern, RegexOptions.IgnoreCase);
            if (match.Success)
            {
                lines[i] = String.Format("{0}: {1}", match, lines[i]);
            }
            else
            {
                lines[i] = $"--------: {lines[i]}";
            }
        }
        return lines;
    }
}
























