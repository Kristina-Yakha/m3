using System;

public static class Raindrops
{
    public static string Convert(int number)
    {
        string drippingSound = "";
        if (number % 3 == 0)
        {
            drippingSound += "Pling";
        }
        if (number % 5 == 0)
        {
            drippingSound += "Plang";
        }
        if (number % 7 == 0)
        {
            drippingSound += "Plong";
        }

        else if ((number % 3 != 0) && (number % 5 != 0) && (number % 7 != 0))
        {
            drippingSound = number.ToString();
        }
        return drippingSound;
    }
}