using System;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Net.NetworkInformation;

namespace BirdCountExercise
{
   
    class BirdCount
    {
        private int[] birdsPerDay;
       

        public BirdCount(int[] birdsPerDay)
        {
            this.birdsPerDay = birdsPerDay;
        }

        public static int[] LastWeek()
        {
            //For comparison purposes, you always keep a copy of last week's counts nearby, which were: 0, 2, 5, 3, 7, 8 and 4.
            //Implement the (static) BirdCount.LastWeek() method that returns last week's counts:

            int[] birdsLastWeek = { 0, 2, 5, 3, 7, 8, 4 };
            return birdsLastWeek;
        }
        public int Today()
        {

            // Implement the BirdCount.Today() method to
            // return how many birds visited your garden today.
            // The bird counts are ordered by day, with the first element being the count of the oldest day,
            // and the last element being today's count.

            int today = birdsPerDay.Length-1;
            return birdsPerDay[today];
            

        }

        //Implement the BirdCount.IncrementTodaysCount() method to increment today's count:
        public void IncrementTodaysCount()
        {
            int today = birdsPerDay.Length - 1;
            birdsPerDay[today] = Today() + 1;

        }

        //Implement the BirdCount.HasDayWithoutBirds() method that returns true if there was a day at which zero birds visited the garden; otherwise, return false:
        public bool HasDayWithoutBirds()
        {
            //iterate through the array and check whether there is a 0 value, then return true
            int index = Array.IndexOf(birdsPerDay, 0);
            if (index == -1)
            {
                return false;
            } else
            {
                return true;
            }
        }

        //Implement the BirdCount.CountForFirstDays() method that
        //returns the number of birds that have visited your garden from the start of the week,
        //but limit the count to the specified number of days from the start of the week.
        public int CountForFirstDays(int numberOfDays)
        {
            int numBirds = 0;

            for (int i = 0; i< numberOfDays; i++)
            {
                numBirds = numBirds + birdsPerDay[i];
            }

            return numBirds;

        }

        //Some days are busier that others. A busy day is one where five or more birds have visited your garden.
        //Implement the BirdCount.BusyDays() method to return the number of busy days:
        public int BusyDays()
        {
            int busyDays = 0;

            for (int i = 0; i < (birdsPerDay.Length-1); i++)
            {
                if (birdsPerDay[i] >= 5)
                {
                    busyDays++;
                }
            }

            return busyDays;
        }
    }
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(BirdCount.LastWeek());
        }
    }

}
