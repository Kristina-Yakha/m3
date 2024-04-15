using System;
using System.Globalization;

namespace InterestIsInteresting
{
    class Program
    {
        public static void Main(string[] args)
        {
            var SavingsAccount = new SavingsAccount();

            double balance;
            double targetBalance;
            //double balance = 200.75;
            //double targetBalance = 214.88;

            //ReadLine for correct console input, also the ReadLine requires european number punctuation 200,75 instead of 200.75

            Console.Write("Your balance: ");
            balance = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Your target balance: ");
            targetBalance = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Your interest rate: " + SavingsAccount.InterestRate(balance));
            Console.WriteLine("Your interest: " + Math.Round(SavingsAccount.Interest(balance),4)); 
            Console.WriteLine("Your annual balance update is: " + Math.Round(SavingsAccount.AnnualBalanceUpdate(balance),4));
            Console.WriteLine("Years needed to reach your desired balance: " + SavingsAccount.YearsBeforeDesiredBalance(balance, targetBalance));

        }
    }

    class SavingsAccount
    {
        //Implement the (static) SavingsAccount.InterestRate() method to calculate the interest rate based on the specified balance

        //3.213% for a negative balance(balance gets more negative).
        //0.5% for a positive balance less than 1000 dollars.
        //1.621% for a positive balance greater than or equal to 1000 dollars and less than 5000 dollars.
        //2.475% for a positive balance greater than or equal to 5000 dollars.
        

        public static float InterestRate(double balance)
        {
            float interestRate = 0;

            if (balance <= 0)
            {
                interestRate = 0.03213f;
            } else if (balance < 1000)
            {
                interestRate = 0.005f;
            } else if ((balance >= 1000)&&(balance < 5000))
            {
                interestRate = 0.01621f;
            } else
            {
                interestRate = 0.02475f;
            }

            return interestRate;
        }

        //Implement the (static) SavingsAccount.Interest() method to calculate the interest based on the specified balance:

        //returns 0,25.. why?

        public static double Interest(double balance)
        {
            double interest =  (double)InterestRate(balance) * balance;

            return interest;

         }

        //Implement the (static) SavingsAccount.AnnualBalanceUpdate() method to calculate the annual balance update, taking into account the interest rate:
        public static double AnnualBalanceUpdate(double balance)
        {

            double updatedBalance = Interest(balance) + balance;
            return updatedBalance;
        }

        //Implement the (static) SavingsAccount.YearsBeforeDesiredBalance() method to calculate the minimum number of years required to reach the desired balance given annually compounding interest:

        public static int YearsBeforeDesiredBalance(double balance, double targetBalance)
        {
            int years = 0;
            
            while (balance < targetBalance)
            {
                balance = AnnualBalanceUpdate(balance);
                years++;
            }


            return years;

        }


    }
}
