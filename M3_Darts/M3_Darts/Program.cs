using System;

public static class Darts
{
    public static int Score(double x, double y)
    {
        double coordinate = Math.Sqrt(x * x + y * y);

        if (coordinate <= 1) return 10;
        else if (coordinate <= 5) return 5;
        else if (coordinate <= 10) return 1;
        else return 0;

    }
}
