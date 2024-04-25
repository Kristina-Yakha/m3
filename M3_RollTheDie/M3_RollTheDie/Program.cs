using System;

public class Player
{
    public int RollDie()
    {
        Random dice = new Random();
        return dice.Next(1, 19);

    }

    public double GenerateSpellStrength()
    {
        Random spell = new Random();
        return spell.NextDouble() * 100;
    }
}

