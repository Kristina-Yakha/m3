using System;

namespace M3_D7_Structures
{
     struct StructurestructName
    {
        public int varName;
        public void structMethod()
        {
            Console.WriteLine("inside structure");
        }
    }

    internal class Structures
    {
        public static void Main(string[] args)
        {
            StructurestructName obj2 = new StructurestructName();
            obj2.structMethod();
        }
    }
}


