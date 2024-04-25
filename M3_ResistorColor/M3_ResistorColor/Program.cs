using System;


public static class ResistorColor
{
    public static int ColorCode(string color)
    {
        color = color.ToLower();
        int colorCode = Array.IndexOf(Colors(), color);
        return colorCode;
    }

    public static string[] Colors()
    {
        string[] colorArray = { "black", "brown", "red", "orange", "yellow", "green", "blue", "violet", "grey", "white" };

        return colorArray;

    }

}