using System;

public static class ArmstrongNumbers
{
    public static bool IsArmstrongNumber(int number)
    {
        char[] digits = Convert.ToString(number).ToCharArray();
        double numberOfDigits = digits.Length;
        double sum = 0;

        for (int i = 0; i < digits.Length; i++)
        {
            sum += Math.Pow(Convert.ToInt32(new string(digits[i], 1)), numberOfDigits);
        }


        if (sum == number)
        {
            return true;
        }
        else
        {
            return false;
        }

    }
}