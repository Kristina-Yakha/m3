using System;

public static class ResistorColorDuo
{


    public static int Value(string[] colors)
    {
        string[] colorCodes = { "black", "brown", "red", "orange", "yellow", "green", "blue", "violet", "grey", "white" };

        //finde die erste farbe aus colors in dem colorArray und gib den index zurück

        string digit = "";


        for (int i = 0; i <= 1; i++)
        {
            for (int j = 0; j < colorCodes.Length; j++)
            {
                if (colors[i] == colorCodes[j])
                {
                    digit += j.ToString();
                }
            }

        }



        return Int32.Parse(digit);
    }
}
