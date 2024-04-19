using System;

namespace StringAndArrays
{
    class StringReversal
    {
       public void Pangram(string input)
        {
            string[] words = input.Split(" ");


            for (int i = 0; i < words.Length-1; i++)
            {
                char[] wordStore = words[i].ToCharArray();
                Array.Reverse(wordStore);
                string reWord = new string(wordStore);
                words[i] = reWord;
            }
           

            Console.WriteLine(String.Join(" ", words));


        }

        public void OrderStream(string input)
        {
            //separate the imput and put it into an array

            string[] orderIDs = input.Split(",");

            //Sort the array

            Array.Sort(orderIDs);

            foreach(string orderID in orderIDs)
            {
                Console.Write(orderID);
                if (orderID.Length != 4) Console.Write(" - Error");
                Console.WriteLine("");
            }

        }
    }

    class Program
    {
        public static void Main(string[] args)
        {
            StringReversal pangr = new StringReversal();
            pangr.Pangram("The quick brown fox jumps over the lazy dog");
            pangr.OrderStream("B123,C234,A345,C15,B177,G3003,C235,B179");

            //-> ehT kciuq nworb xof spmuj revo eht yzal god
        }
    }

}
