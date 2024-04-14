using System;

namespace InterestIsInteresting
{
    class Program
    {
        public static void Main(string[] args)
        {
            var SavingsAccount = new SavingsAccount();
            //decimal balance = 200.75m;

            Console.Write("Your balance: ");
            decimal balance = Convert.ToDecimal(Console.Read());
            Console.WriteLine("Your interest rate: " + SavingsAccount.InterestRate(balance));
        }
    }

    class SavingsAccount
    {
        //Implement the (static) SavingsAccount.InterestRate() method to calculate the interest rate based on the specified balance

        //3.213% for a negative balance(balance gets more negative).
        //0.5% for a positive balance less than 1000 dollars.
        //1.621% for a positive balance greater than or equal to 1000 dollars and less than 5000 dollars.
        //2.475% for a positive balance greater than or equal to 5000 dollars.


        public static float InterestRate(decimal balance)
        {
            float interestRate = 0;

            if (balance <= 0)
            {
                interestRate = 0.3213f;
            } else if (balance < 1000)
            {
                interestRate = 0.05f;
            } else if ((balance >= 1000)&&(balance < 5000))
            {
                interestRate = 0.1621f;
            } else
            {
                interestRate = 0.2475f;
            }

            return interestRate;
        }
    }
}
