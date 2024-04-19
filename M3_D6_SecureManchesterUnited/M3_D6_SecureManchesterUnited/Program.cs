using System;

public class SecurityPassMaker
{

    // return the value of the Title field instances of all classes derived from Staff and, otherwise, "Too Important for a Security Pass".
    // if the staff member is a member of the security team (either of type Security or one of its derivatives) then the text " Priority Personnel" should be displayed after the title.
    //" Priority Personnel" should not be displayed for instances of type SecurityJunior, SecurityIntern and PoliceLiaison.
    public string GetDisplayName(TeamSupport support)
    {
        string displayName;

        if (support is Staff)
        {
            displayName = support.Title;
            if (support.GetType() == typeof(Security)) displayName = $"{displayName} Priority Personnel";
        }

        else displayName = "Too Important for a Security Pass";
        
        return displayName;

    }

    
}

class Program
{
    public static void Main(string[] args)
    {
        var spm = new SecurityPassMaker();
        Console.WriteLine(spm.GetDisplayName(new Manager()));
        Console.WriteLine(spm.GetDisplayName(new Physio()));
        Console.WriteLine(spm.GetDisplayName(new Security()));
        Console.WriteLine(spm.GetDisplayName(new SecurityJunior()));
    }
}

/**** Please do not alter the code below ****/

public interface TeamSupport { string Title { get; } }

public abstract class Staff : TeamSupport { public abstract string Title { get; } }

public class Manager : TeamSupport { public string Title { get; } = "The Manager"; }

public class Chairman : TeamSupport { public string Title { get; } = "The Chairman"; }

public class Physio : Staff { public override string Title { get; } = "The Physio"; }

public class OffensiveCoach : Staff { public override string Title { get; } = "Offensive Coach"; }

public class GoalKeepingCoach : Staff { public override string Title { get; } = "Goal Keeping Coach"; }

public class Security : Staff { public override string Title { get; } = "Security Team Member"; }

public class SecurityJunior : Security { public override string Title { get; } = "Security Junior"; }

public class SecurityIntern : Security { public override string Title { get; } = "Security Intern"; }

public class PoliceLiaison : Security { public override string Title { get; } = "Police Liaison Officer"; }
