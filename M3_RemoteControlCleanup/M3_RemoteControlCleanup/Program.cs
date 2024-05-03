
public class RemoteControlCar
{
    public string CurrentSponsor { get; private set; }
    public ICarTelemetry Telemetry;
    private Speed currentSpeed;

    // TODO encapsulate the methods suffixed with "_Telemetry" in their own class
    // dropping the suffix from the method name


    public RemoteControlCar()
    {
        this.Telemetry = new CarTelemetry(this);
    }

    public interface ICarTelemetry
    {

        public void Calibrate();
        public bool SelfTest();
        public void ShowSponsor(string sponsorName);
        public void SetSpeed(decimal amount, string unitsString);

    }

    protected class CarTelemetry : ICarTelemetry
    {
        private RemoteControlCar remoteControlCar;


        public CarTelemetry(RemoteControlCar remoteControlCar)
        {
            this.remoteControlCar = remoteControlCar;
        }

        public void Calibrate()
        {

        }

        public bool SelfTest()
        {
            return true;
        }

        public void ShowSponsor(string sponsorName)
        {
            remoteControlCar.SetSponsor(sponsorName);
        }

        public void SetSpeed(decimal amount, string unitsString)
        {
            SpeedUnits speedUnits = SpeedUnits.MetersPerSecond;
            if (unitsString == "cps")
            {
                speedUnits = SpeedUnits.CentimetersPerSecond;
            }

            remoteControlCar.SetSpeed(new Speed(amount, speedUnits));
        }
    }


    public string GetSpeed()
    {
        return currentSpeed.ToString();
    }

    private void SetSponsor(string sponsorName)
    {
        CurrentSponsor = sponsorName;

    }

    private void SetSpeed(Speed speed)
    {
        currentSpeed = speed;
    }

    protected enum SpeedUnits
    {
        MetersPerSecond,
        CentimetersPerSecond
    }




    protected struct Speed
    {
        public decimal Amount { get; }
        public SpeedUnits SpeedUnits { get; }

        public Speed(decimal amount, SpeedUnits speedUnits)
        {
            Amount = amount;
            SpeedUnits = speedUnits;
        }

        public override string ToString()
        {
            string unitsString = "meters per second";
            if (SpeedUnits == SpeedUnits.CentimetersPerSecond)
            {
                unitsString = "centimeters per second";
            }

            return Amount + " " + unitsString;
        }
    }
}





