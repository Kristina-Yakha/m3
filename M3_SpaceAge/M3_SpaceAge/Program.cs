using System;

public class SpaceAge
{
    int seconds;
    public double secondsEarth = 31557600;

    public SpaceAge(int seconds)
    {
        this.seconds = seconds;
    }

    public double OnEarth()
    {

        return seconds / secondsEarth;

    }

    public double OnMercury()
    {

        return seconds / (secondsEarth * 0.2408467);
    }

    public double OnVenus()
    {
        //0.61519726 Earth years
        return seconds / (secondsEarth * 0.61519726);
    }

    public double OnMars()
    {

        //1.8808158 Earth years
        return seconds / (secondsEarth * 1.8808158);
    }

    public double OnJupiter()
    {
        //11.862615 Earth years
        return seconds / (secondsEarth * 11.862615);
    }

    public double OnSaturn()
    {

        //29.447498 Earth years
        return seconds / (secondsEarth * 29.447498);
    }

    public double OnUranus()
    {

        //84.016846 Earth years
        return seconds / (secondsEarth * 84.016846);
    }

    public double OnNeptune()
    {

        //164.79132 Earth years
        return seconds / (secondsEarth * 164.79132);
    }
}