using System;
using System.Collections.Generic;

public enum Plant
{
    Violets,
    Radishes,
    Clover,
    Grass
}

public class KindergartenGarden
{
    private string firstRow;
    private string secondRow;
    private string[] students = { "Alice", "Bob", "Charlie", "David", "Eve", "Fred", "Ginny", "Harriet", "Ileana", "Joseph", "Kincaid", "Larry" };

    public KindergartenGarden(string diagram)
    {
        string[] garden = diagram.Split('\n');
        firstRow = garden[0];
        secondRow = garden[1];

    }


    public IEnumerable<Plant> Plants(string student)
    {

        int firstPosition = Array.IndexOf(students, student) * 2;
        string studentGarden = $"{firstRow.Substring(firstPosition, 2)}{secondRow.Substring(firstPosition, 2)}";
        char[] studentPlants = studentGarden.ToCharArray();

        List<Plant> plants = new List<Plant>();

        foreach (char studentPlant in studentPlants)
        {
            switch (studentPlant)
            {
                case 'V':
                    plants.Add(Plant.Violets);
                    break;
                case 'R':
                    plants.Add(Plant.Radishes);
                    break;
                case 'C':
                    plants.Add(Plant.Clover);
                    break;
                case 'G':
                    plants.Add(Plant.Grass);
                    break;
                default:
                    break;
            }
        }

        return plants;

    }
}













