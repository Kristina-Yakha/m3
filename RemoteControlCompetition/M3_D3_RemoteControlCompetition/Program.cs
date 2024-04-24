using System;
using System.Collections.Generic;

// TODO implement the IRemoteControlCar interface

public interface IRemoteControlCar
{
    int DistanceTravelled { get; }
    void Drive();
}

public class ProductionRemoteControlCar : IRemoteControlCar, IComparable<ProductionRemoteControlCar>
{

    private int distanceTravelled;
    private int numberOfVictories;

    public int DistanceTravelled
    {
        get
        {
            return distanceTravelled;
        }
        private set
        {
            distanceTravelled = value;
        }
    }

    public int NumberOfVictories
    {
        get
        {
            return numberOfVictories;
        }
        set
        {
            numberOfVictories = value;
        }
    }

    public void Drive()
    {
        DistanceTravelled += 10;
    }

    public int CompareTo(ProductionRemoteControlCar other)
    {

        if (other == null) return 1;

        return numberOfVictories.CompareTo(other.numberOfVictories);
    }

}

public class ExperimentalRemoteControlCar : IRemoteControlCar
{
    private int distanceTravelled;


    public int DistanceTravelled
    {
        get
        {
            return distanceTravelled;
        }
        private set
        {
            distanceTravelled = value;
        }
    }


    public void Drive()
    {
        DistanceTravelled += 20;
    }

}

public static class TestTrack
{

    public static void Race(IRemoteControlCar car)
    {
        car.Drive();
    }

    public static List<ProductionRemoteControlCar> GetRankedCars(ProductionRemoteControlCar prc1,
        ProductionRemoteControlCar prc2)
    {

        List<ProductionRemoteControlCar> rankedCars = new List<ProductionRemoteControlCar>() { prc1, prc2 };
        rankedCars.Sort();
        return rankedCars;

    }
}










