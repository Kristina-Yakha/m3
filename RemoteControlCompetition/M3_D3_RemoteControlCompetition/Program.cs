using System;
using System.Collections.Generic;

// Missing: Implementation of the List<ProductionRemoteControlCar> GetRankedCars(ProductionRemoteControlCar prc1,
// ProductionRemoteControlCar prc2) -> what do i have to do?

public interface IRemoteControlCar
{
    public void Drive();
    public int DistanceTravelled { get; set; }
    public int NumberOfVictories { get; set; }
}

public class ProductionRemoteControlCar : IRemoteControlCar, IComparable<ProductionRemoteControlCar>
{

    private int distanceTravelled;
    private int numberOfVictories;

    public int DistanceTravelled
    {
        get { return distanceTravelled; }
        set { }
    }


    public int NumberOfVictories
    {
        get { return numberOfVictories; }
        set { numberOfVictories = value; }
    }

    public void Drive()
    {
        distanceTravelled += 10;
    }

    public int CompareTo(ProductionRemoteControlCar other)
    {

        if (other == null)
        {
            return 1;
        }

        return NumberOfVictories.CompareTo(other.NumberOfVictories);
    }

}


public class ExperimentalRemoteControlCar : IRemoteControlCar
{
    private int distanceTravelled;
    private int numberOfVictories;

    public int DistanceTravelled
    {
        get { return distanceTravelled; }
        set { }
    }

    public int NumberOfVictories
    {
        get { return numberOfVictories; }
        set { numberOfVictories = value; }
    }

    public void Drive()
    {
        distanceTravelled += 20;
    }
}

public static class TestTrack
{
    public static void Race(IRemoteControlCar car)
    {
        car.Drive();
    }


    //Implement the static TestTrack.GetRankedCars() to return the cars passed is sorted in ascending order of number of victories. -> Sort()? or CompareTo?
    public static List<ProductionRemoteControlCar> GetRankedCars(ProductionRemoteControlCar prc1,
        ProductionRemoteControlCar prc2)
    {
        prc1.CompareTo(prc2);

    }
}
