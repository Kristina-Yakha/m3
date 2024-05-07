using System;

public static class Gigasecond
{
    public static DateTime Add(DateTime moment)
    {
        double gigaSecond = 1000000000.00;
        return moment.AddSeconds(gigaSecond);

    }
}