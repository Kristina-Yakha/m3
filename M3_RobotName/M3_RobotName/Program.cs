using System;
using System.Collections.Generic;

public class Robot
{
    private string name = "";
    private static HashSet<string> nameList = new HashSet<string>();


    public string Name
    {
        get
        {
            return name;
        }
    }



    public Robot()
    {

        Reset();

    }


    public void Reset()
    {
        //a new name is created
        name = GetUniqueName();
    }

    public string GenerateName()
    {

        char[] letters = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };
        Random random = new Random();
        string newName = "";
        for (int i = 0; i < 2; i++)
        {

            int index = random.Next(0, 26);
            newName += letters[index].ToString();
        }

        for (int y = 0; y < 3; y++)
        {
            newName += random.Next(0, 10).ToString();
        }
        return newName;
    }

    public string GetUniqueName()
    {

        string newName = GenerateName();
        while (nameList.Contains(newName))
        {
            newName = GenerateName();
        }
        nameList.Add(newName);
        return newName;

    }



}