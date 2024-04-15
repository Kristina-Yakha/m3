using System;
using System.Runtime.CompilerServices;

namespace NeedForSpeed
{
    class RemoteControlCar {
        public int speed;
        int batteryDrain;
        int metersDriven = 0;
        int batteryCharge = 100;


        public RemoteControlCar (int speed, int batteryDrain)
        {
            this.speed = speed;
            this.batteryDrain = batteryDrain;   
        }

        //Implement the RemoteControlCar.Drive() method that updates the number of meters driven based on the car's speed
        public void Drive()
        {
                metersDriven = metersDriven + speed;
                batteryCharge = batteryCharge - batteryDrain;          
                       
        }

        //Also implement the RemoteControlCar.DistanceDriven() method to return the number of meters driven by the car

        public int DistanceDriven()
        {
            Console.WriteLine("The car has driven: " + metersDriven + "m");
            return metersDriven;

        }

        public bool BatteryDrained()
        {
            if ((batteryCharge - batteryDrain) <0)
            {
                Console.WriteLine("Battery drained");
                return true;
                
            } else
            {
                //Console.WriteLine("Keep going");
                return false;
            }
        }

        
        public static RemoteControlCar Nitro()
        {
            return new RemoteControlCar(50, 4);
        }
    }
    class RaceTrack
    {
        int distance;
        public RaceTrack(int distance)
        {
            this.distance = distance;
        }

        //To finish a race track, a car has to be able to drive the track's distance. This means not draining its battery before having crossed the finish line.
        //Implement the RaceTrack.TryFinishTrack() method that takes a RemoteControlCar instance as its parameter and returns true if the car can finish the race track;
        //otherwise, return false:

        public bool TryFinishTrack(RemoteControlCar car)
        {

         
           while ((distance > car.DistanceDriven()))
            {
                if (car.BatteryDrained())
                {
                    Console.WriteLine("The car could not finish the race");
                    return false;
                } else
                {
                    car.Drive();
                }

            }

            Console.WriteLine("The car has successfully finished the race");
            return true;
                        
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            
            var raceTrack = new RaceTrack(400);
            var car1 = new RemoteControlCar(5, 2);
            raceTrack.TryFinishTrack(car1);
            /*
            var nitro = RemoteControlCar.Nitro();
            nitro.DistanceDriven();
            nitro.Drive();
            nitro.DistanceDriven();
            nitro.BatteryDrained();
            */


        }
    }
}
