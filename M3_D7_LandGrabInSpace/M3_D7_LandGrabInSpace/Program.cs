using System;
using System.Collections.Generic;

public struct Coord
{
    public Coord(ushort x, ushort y)
    {
        X = x;
        Y = y;
    }

    public ushort X { get; }
    public ushort Y { get; }

    //calculate distance of the sides



}

public struct Plot
{
    public double longestSide;

    public Coord coordA { get; }
    public Coord coordB { get; }
    public Coord coordC { get; }
    public Coord coordD { get; }

    public Plot(Coord coordA, Coord coordB, Coord coordC, Coord coordD)
    {
        this.coordA = coordA;
        this.coordB = coordB;
        this.coordC = coordC;
        this.coordD = coordD;

        longestSide = LongestSide();
    }



    public int GetHashCode()
    {
        var hash = new HashCode();

        hash.Add(coordA);
        hash.Add(coordB);
        hash.Add(coordC);
        hash.Add(coordD);

        return hash.ToHashCode();
    }

    private double LongestSide()
    {
        double[] sides = { SideLength(coordA, coordB), SideLength(coordB, coordC), SideLength(coordC, coordD), SideLength(coordD, coordA) };

        Array.Sort(sides);

        return sides[3];

    }

    private double SideLength(Coord coordA, Coord coordB)
    {

        double paramA;
        double paramB;

        if (coordA.X >= coordB.X) paramA = Math.Pow(coordA.X - coordB.X, 2);
        else paramA = Math.Pow(coordB.X - coordA.X, 2);

        if (coordA.Y >= coordB.Y) paramB = Math.Pow(coordA.Y - coordB.Y, 2);
        else paramB = Math.Pow(coordB.Y - coordA.Y, 2);

        return Math.Sqrt(paramA + paramB);

    }

}


public class ClaimsHandler
{
    private HashSet<int> registeredPlot;
    public int previousPlot;
    public Plot largestSidePlot;


    public ClaimsHandler()
    {
        registeredPlot = new HashSet<int>();
    }



    public void StakeClaim(Plot plot)
    {
        int hash = plot.GetHashCode();


        if (!IsClaimStaked(plot))
        {

            registeredPlot.Add(plot.GetHashCode());
            previousPlot = hash;
            if (plot.longestSide >= largestSidePlot.longestSide) largestSidePlot = plot;

        }

    }

    public bool IsClaimStaked(Plot plot)
    {
        return registeredPlot.Contains(plot.GetHashCode());
    }

    public bool IsLastClaim(Plot plot)
    {
        return previousPlot.Equals(plot.GetHashCode());
    }

    public Plot GetClaimWithLongestSide()
    {
        return largestSidePlot;
    }
}
