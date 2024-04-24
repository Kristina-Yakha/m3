using System;

namespace M3_D7_Strings
{

    internal class String
    {
        public void concatination ()
        {
            string firstName = "Mannoor";
            string lastName = "Dhingra";

            // concatination with +
            string fullname = firstName + " " + lastName;
            Console.WriteLine(fullname);
            string name = string.Concat(firstName, lastName);
            Console.WriteLine(name);
            string iName = $"Full name is: {firstName} {lastName}";
            Console.WriteLine(iName);
        }

        public void StringOperations()
        {
            string name = " Hello World! ";
            Console.WriteLine(name.Substring(3));
            Console.WriteLine(name.Length);
            string [] nameS = name.Split(' ');
            foreach (var s in nameS)
            {
                Console.Write(s);
            }

            Console.WriteLine(string.Join(",,", nameS));
            Console.WriteLine(name.Replace("Hello", "hey"));
            Console.WriteLine(name.ToLower());
            Console.WriteLine(name.ToUpper());
            Console.WriteLine(name.Trim());
            Console.WriteLine(name.IndexOf("W"));

            string fullName = "Manoor";
            int age = 26;
            string formatted = string.Format("fullName = {0}, Age = {1}", fullName, age);
            Console.WriteLine(formatted);
            Console.WriteLine(string.Format("name = {0}", age));

        }
        
        
    }
    class Program
    {
        public static void Main(string[] args)
        {
            String obj = new String();
            obj.concatination();
        }
    }

}
