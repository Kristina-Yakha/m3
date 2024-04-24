using System;

public static class BeerSong
{
    public static string Recite(int startBottles, int takeDown)
    {
        string song = "";
        int numBottles = startBottles;

        while (takeDown > 0)
        {
            if (numBottles > 1)
            {
                string bottle = "bottles";

                song += $"{numBottles} {bottle} of beer on the wall, {numBottles} {bottle} of beer.\n";
                numBottles--;

                if (numBottles == 1) bottle = "bottle";
                song += $"Take one down and pass it around, {numBottles} {bottle} of beer on the wall.";


            }

            else if (numBottles == 1)
            {
                song += $"1 bottle of beer on the wall, 1 bottle of beer.\nTake it down and pass it around, no more bottles of beer on the wall.";
                numBottles--;
            }
            else if (numBottles == 0)
            {
                song += $"No more bottles of beer on the wall, no more bottles of beer.\nGo to the store and buy some more, 99 bottles of beer on the wall.";
                break;
            }

            takeDown--;
            if (takeDown > 0) song += "\n\n";


        }

        return song;

    }
}