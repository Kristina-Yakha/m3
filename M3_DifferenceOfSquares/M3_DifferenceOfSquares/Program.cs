﻿using System;

public static class DifferenceOfSquares
{
    public static int CalculateSquareOfSum(int max)
    {
        int sum = 0;

        for (int i = max; i > 0; i--)
        {
            sum += i;
        }

        return sum *= sum;
    }

    public static int CalculateSumOfSquares(int max)
    {
        int sum = 0;

        for (int i = max; i > 0; i--)
        {
            sum += (i * i);
        }
        return sum;

    }

    public static int CalculateDifferenceOfSquares(int max)
    {

        return (CalculateSquareOfSum(max) - CalculateSumOfSquares(max));

    }
}