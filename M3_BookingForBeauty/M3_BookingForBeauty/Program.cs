using System;

static class Appointment
{
    public static DateTime Schedule(string appointmentDateDescription)
    {
        return DateTime.Parse(appointmentDateDescription);
    }

    public static bool HasPassed(DateTime appointmentDate)
    {
        DateTime currentDateTime = DateTime.Now;

        if (appointmentDate < currentDateTime) return true;
        else return false;

    }

    public static bool IsAfternoonAppointment(DateTime appointmentDate)
    {

        int hour = appointmentDate.Hour;
        if (hour >= 12 && hour < 18) return true;
        else return false;
        //>= 12:00 and < 18:00

    }

    public static string Description(DateTime appointmentDate)
    {

        return $"You have an appointment on {appointmentDate:G}.";


    }

    public static DateTime AnniversaryDate()
    {

        return new DateTime(DateTime.Now.Year, 9, 15, 0, 0, 0);


    }
}
