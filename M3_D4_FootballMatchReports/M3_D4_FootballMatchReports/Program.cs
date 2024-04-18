using System;


// taken from https://github.com/exercism/csharp/blob/main/exercises/concept/football-match-reports/OffFieldActivitiesAndCharacters.cs
public class Manager
{
    public string Name { get; }

    public string? Club { get; }

    public Manager(string name, string? club)
    {
        this.Name = name;
        this.Club = club;
    }
}

public class Incident
{
    public virtual string GetDescription() => "An incident happened.";
}

public class Foul : Incident
{
    public override string GetDescription() => "The referee deemed a foul.";
}

public class Injury : Incident
{
    private readonly int player;

    public Injury(int player)
    {
        this.player = player;
    }

    public override string GetDescription() => $"Player {player} is injured.";
}

//

public static class PlayAnalyzer
{



    public static string AnalyzeOnField(int shirtNum)
    {
        string position;

        switch (shirtNum)
        {
            case 1:
                position = "goalie";
                break;
            case 2:
                position = "left back";
                break;
            case 3:
                position = "center back";
                break;
            case 4:
                position = "center back";
                break;
            case 5:
                position = "right back";
                break;
            case 6:
                position = "midfielder";
                break;
            case 7:
                position = "midfielder";
                break;
            case 8:
                position = "midfielder";
                break;
            case 9:
                position = "left wing";
                break;
            case 10:
                position = "striker";
                break;
            case 11:
                position = "right wing";
                break;
            default:
                throw new ArgumentOutOfRangeException("Shirt number does not exist.");
             
        }

        return position;

    }

    public static string AnalyzeOffField(object report)
    {


        var type = report.GetType();

        if (type == typeof(string))
        {
            return (string)report;
        }
        else if (type == typeof(int))
        {
            return $"There are {report} supporters at the match.";
        }
        else if (type == typeof(Foul))
        {
            return "The referee deemed a foul.";
        }
        else if (type == typeof(Injury))
        {
            return $"Oh no! {((Injury)report).GetDescription()} Medics are on the field.";
        }
        else if (type == typeof(Incident))
        {
            return "An incident happened.";
        }
        else if (type == typeof(Manager))
        {
            string name = ((Manager)report).Name;
            string club = ((Manager)report).Club;
            if (club != null)
                return $"{name} ({club})";
            else
                return name;
        }

        else
        {
            throw new ArgumentException(typeof(Incident).ToString() + report.GetType().ToString());
        }


    }

}

