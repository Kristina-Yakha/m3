using System;


namespace M3_D6_SqueakyClean
{
    public static class Identifier
    {
        public static string Clean(string identifier)
        {

            string cleanIdentifier;

            // Empty spaces are replaced by underscores

            cleanIdentifier = identifier.Replace(' ', '_');

            // Control Characters are replaces with upper case string "CTRL"

            //char.isControl(ch)

            char[] chars = cleanIdentifier.ToCharArray();

            for (int i = 0; i < chars.Length; i++) {
                if (char.IsControl(chars[i])) chars[i] = ' ';
            }

            cleanIdentifier = new string(chars);

            cleanIdentifier = cleanIdentifier.Replace(" ", "CTRL");

            return cleanIdentifier; 
                   






                
            
         }

            // replace control characters with the upper case string "CTRL"



            //put everything together in a string

         
         
        

        public static void Main(string[] args)
        {
           
           Console.WriteLine(Clean("my   Id"));
           Console.WriteLine(Clean("my\0Id"));
        }
    }

    
}



