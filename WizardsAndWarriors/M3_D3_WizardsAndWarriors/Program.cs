using System;

abstract class Character
{
    string characterType;
   
    protected Character(string characterType)
    {
        
        this.characterType = characterType;
        Console.WriteLine(ToString());
    }

    public abstract int DamagePoints(Character target);

    public virtual bool Vulnerable()
    {
        return false;
    }

    public override string ToString()
    {
        return "Character is a " + characterType;
    }
}

class Warrior : Character
{
    public Warrior() : base("Warrior")
    {
        

    }

    //Implement the Warrior.DamagePoints() method to return the damage points dealt:
    //10 damage points when the target is vulnerable, 6 damage points when not.
    public override int DamagePoints(Character target)
    {
       

        if (!target.Vulnerable())
        {
            return 6;

        }
        else
        {
            return 10;
        }

    }

    class Wizard : Character
    {
        bool spellPrepared;
        public Wizard() : base("Wizard")
        {
            spellPrepared = false;
            Vulnerable();
            
        }

        //Implement the Wizard.DamagePoints() method to return the damage points dealt:
        //12 damage points when a spell has been prepared, 3 damage points when not.
        public override int DamagePoints(Character target)
        {
           if (spellPrepared == true)
            {
                return 12;

            }
            else
            {
                return 3;
            }
        }

        public void PrepareSpell()
        {          
            spellPrepared = true;
            Vulnerable();

        }
        //Ensure that the Vulnerable() method returns true if the wizard did not prepare a spell; otherwise, return false.
        public override bool Vulnerable()
        {
            if (spellPrepared)
            {
                return false;
            }
            else
            {
                return true;
            }

        }

    }
    class Program
    {
        public static void Main(string[] args)
        {
            
            Warrior war1 = new Warrior();
            Wizard wiz1 = new Wizard();
            Console.WriteLine(war1.ToString());
            //Console.WriteLine(wiz1.ToString());
            //Console.WriteLine(war1.Vulnerable());
            Console.WriteLine(wiz1.Vulnerable());
            //wiz1.PrepareSpell();
            Console.WriteLine(wiz1.Vulnerable());
            Console.WriteLine(war1.DamagePoints(wiz1));
            Console.WriteLine(wiz1.DamagePoints(war1));
            wiz1.PrepareSpell();
            Console.WriteLine(wiz1.DamagePoints(war1));
            Console.WriteLine(war1.DamagePoints(wiz1));
        }
    } 
}