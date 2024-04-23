using System;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Text;


namespace M3_D6_SqueakyClean
{
    public static class Identifier
    {
        
        
 

        public static string Clean(string identifier)

        {
          
               
            // Empty spaces are replaced by underscores

                identifier= identifier.Replace(' ', '_');



            
                char[] chars = identifier.ToCharArray();
            
                int controlIndex = 0;
                string pattern = @"(\p{IsGreek}+(\s)?)+";

            while (controlIndex < chars.Length)
                {
                    //replace control characers with upper case striong "CTRL"

                    if (char.IsControl(chars[controlIndex]))
                    {
                        identifier = identifier.Replace(Char.ToString(chars[controlIndex]), "CTRL");
                    }

                    //Convert Kebab_Case to camelCase

                    else if (chars[controlIndex] == '-')
                    {
                        string kebab = Char.ToString(Char.ToUpper(chars[controlIndex + 1]));
                        identifier = identifier.Replace(("-" + Char.ToString(chars[controlIndex + 1])), kebab);
                    }

                    //Omit Characters that are not letters

                    else if (!char.IsLetter(chars[controlIndex]))
                {
                    identifier = identifier.Replace(Char.ToString(chars[controlIndex]), "");

                } else if (chars[controlIndex] == '_')
                {
                //https://learn.microsoft.com/de-de/dotnet/api/system.char.gethashcode?view=net-8.0
                //https://learn.microsoft.com/de-de/dotnet/standard/base-types/character-classes-in-regular-expressions
                }



                controlIndex++;
                    }


            


                    return identifier; 
                
            
         }

            // replace control characters with the upper case string "CTRL"



            //put everything together in a string

         
         
        

        public static void Main(string[] args)
        {
           
           Console.WriteLine(Clean("my   Id"));
           Console.WriteLine(Clean("my\0Id"));
           Console.WriteLine(Clean("à-bç-df"));
           Console.WriteLine(Clean("1😀2😀3😀"));
            //Console.WriteLine(Clean("MyΟβιεγτFinder"));
            char greek = 'γ';
           // Console.WriteLine(Char.IsAscii(greek));
           // Console.WriteLine(Char.IsAscii('1'));
         

        }
    }

    
}



