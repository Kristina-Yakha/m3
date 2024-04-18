using System;

namespace CoinFlip
{
    class BusinessRules
    {
        public void CheckAccess(string permission, int level)
        {
            if (permission.Contains("Admin") && level > 55)
            {
                Console.WriteLine("Welcome, Super Admin user.");
            }
            else if (permission.Contains("Admin") && level <= 55)
            {
                Console.WriteLine("Welcome Admin user");
            } else if (permission.Contains("Manager") && level >= 20)
            {
                Console.WriteLine("Contact an Admin for access");
            } else if (permission.Contains("Manager") && level < 20)
            {
                Console.WriteLine("You do not have sufficient privileges");
            } else
            {
                Console.WriteLine("You do not have sufficient privileges");
            }
            
        }

    }
    class Program
    {   
        static string CoinFlip()
        {
            Random randomNumber = new Random();
            return (randomNumber.Next(0, 2)==0)? "head" : "tails";
            
        } 


        static void Main(string[] args)
        {
            Console.WriteLine(CoinFlip());
            string permission = "Admin|Manager";
            int level = 55;

            BusinessRules business = new BusinessRules();
            business.CheckAccess(permission, level);
        }
    }
}
