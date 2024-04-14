using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Threading;

namespace AnnalynsInfiltration
{

    class Program 
    { 
        public static void Main(string[] args) 
        {
            bool knightAwake = true;
            bool prisonerAwake = true;
            bool archerAwake = false;
            bool hasDog = false;

            var questLogic = new QuestLogic();
            
            Console.WriteLine("Can Annalyn do a fast attack? " + questLogic.CanFastAttack(knightAwake));
            Console.WriteLine("Can Annalyn spy? " + questLogic.CanSpy(prisonerAwake, archerAwake, knightAwake));
            Console.WriteLine("Can Annalyn signal the prisoner? " + questLogic.CanSignalPrisoner(prisonerAwake, archerAwake));
            Console.WriteLine("Can Annalyn free the prisoner? " + questLogic.CanFreePrisoner(prisonerAwake, archerAwake, knightAwake, hasDog));

        }

        public class QuestLogic
        {

            public bool CanFastAttack(bool knightAwake)
            {
                if (knightAwake == false)
                {
                  return true;
                } else
                {
                    return false;
                }
            }
            //Implement the(static) QuestLogic.CanSpy() method that takes three boolean values,
            //indicating if the knight, archer and the prisoner, respectively, are awake.
            //The method returns true if the group can be spied upon, based on the state of the three characters.
            //Otherwise, returns false:

            public bool CanSpy(bool prisonerAwake, bool archerAwake, bool knightAwake)
            {
                if ((!prisonerAwake && !archerAwake && knightAwake) || (prisonerAwake && !archerAwake && !knightAwake) || (!prisonerAwake && archerAwake && !knightAwake))
                    { 
                    return true; 
                
                } else
                {
                    return false;
                }

            }

            //Implement the(static) QuestLogic.CanSignalPrisoner() method that takes two boolean values, indicating
            //if the archer and the prisoner, respectively, are awake.The method 
            //returns true if the prisoner can be signalled, based on the state of the two characters. 
            //Otherwise, returns false:
            
            public bool CanSignalPrisoner(bool prisonerAwake, bool archerAwake)
            {
                if (prisonerAwake && !archerAwake) 
                {
                    return true;
                } else
                {
                    return false;
                }
            }

            //Implement the(static) QuestLogic.CanFreePrisoner() method that takes
            //four boolean values.The first three parameters indicate if the knight, archer and the prisoner, respectively, are awake.
            //The last parameter indicates if Annalyn's pet dog is present.
            //The method returns true if the prisoner can be freed based on the state of the three characters and Annalyn's pet dog presence.
            //Otherwise, it returns false:

            public bool CanFreePrisoner(bool prisonerAwake, bool archerAwake, bool knightAwake, bool hasDog)
            {
                if ((hasDog && !archerAwake)||(!hasDog && prisonerAwake && !knightAwake && !archerAwake)) {
                    return true;
                } else
                {
                    return false;
                }
            }

        }
                    
    }
}