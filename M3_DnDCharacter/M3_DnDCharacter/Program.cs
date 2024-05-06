using System;

public class DndCharacter
{

    private int strength;
    private int dexterity;
    private int constitution;
    private int intelligence;
    private int wisdom;
    private int charisma;
    private int hitpoints;


    public int Strength
    {
        get
        {
            return strength;
        }
    }
    public int Dexterity
    {
        get
        {
            return dexterity;
        }
    }
    public int Constitution
    {
        get
        {
            return constitution;
        }
    }
    public int Intelligence
    {
        get
        {
            return intelligence;
        }
    }
    public int Wisdom
    {
        get
        {
            return wisdom;
        }
    }
    public int Charisma
    {
        get
        {
            return charisma;
        }
    }
    public int Hitpoints
    {
        get
        {
            return hitpoints;
        }
    }

    public static int Modifier(int score)
    {
        double modifier = ((double)score - 10) / 2;
        modifier = Math.Floor(modifier);
        return (int)modifier;
    }

    public static int Ability()
    {
        int abilityScore = 0;
        int smallestDice = 6;
        int[] dices = new int[4];

        Random roll = new Random();

        for (int i = 0; i < dices.Length; i++)
        {
            dices[i] = roll.Next(1, 7);
            abilityScore += dices[i];
            if (dices[i] < smallestDice) smallestDice = dices[i];

        }
        abilityScore -= smallestDice;

        return abilityScore;

    }

    public DndCharacter()
    {

        this.strength = Ability();
        this.dexterity = Ability();
        this.constitution = Ability();
        this.intelligence = Ability();
        this.wisdom = Ability();
        this.charisma = Ability();
        this.hitpoints = 10 + Modifier(Constitution);

    }

    public static DndCharacter Generate()
    {

        DndCharacter character = new DndCharacter();
        return character;
    }
}
