using System;

class RemoteControlCar
{
    int drivenDistance;
    int batteryCharge;

    RemoteControlCar()
    {
        drivenDistance = 0;
        batteryCharge = 2;
    }



    //Implement the (static) RemoteControlCar.Buy() method to return a brand-new remote controlled car instance:
    private static RemoteControlCar Buy()
    {
       return new RemoteControlCar();
    }

    //implement the RemoteControlCar.DistanceDisplay() method to return the distance as displayed on the LED display:

    private void DistanceDisplay()
    {
        Console.WriteLine("Driven "+ drivenDistance + " meters");
    }

    //Implement the RemoteControlCar.BatteryDisplay() method to return the battery percentage as displayed on the LED display

    private void BatteryDisplay()
    {
        Console.WriteLine("Battery at " + batteryCharge + "%");
    }

    //Implement the RemoteControlCar.Drive() method that updates the number of meters driven
    //Update the RemoteControlCar.Drive() method to update the battery percentage:
    //Update the RemoteControlCar.Drive() method to not increase the distance driven nor decrease the battery percentage when the battery is drained (at 0%):
    private void Drive()
    {   
        if (batteryCharge > 0)
        {
            drivenDistance += 20;
            batteryCharge -= 1;
        } else
        {
            Console.WriteLine("Battery empty");
        }
        
    }

    public static void Main(string[] args)
    {
        var car = Buy();

        car.DistanceDisplay();
        car.BatteryDisplay();
        car.Drive();
        car.DistanceDisplay();
        car.BatteryDisplay();
        car.Drive();
        car.DistanceDisplay();
        car.BatteryDisplay();
       
    }

}
