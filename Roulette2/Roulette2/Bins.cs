using System;
using System.Collections.Generic;
using System.Text;

namespace Roulette2
{
    class Bins
    {
        /****************************************
         * A 2D array made up of random numbers
         * strings "1"-"36" "0" and "00" as well 
         * as the color for that number.
         ****************************************/
        public static string[,] RandomArray()
        {
            string[,] ars = new string[38, 2]
            {
                { "0", "Green" },
                {"2", "Black" },
                {"14", "Red" },
                {"35", "Black" },
                {"23", "Red" },
                {"4", "Black" },
                {"16", "Red" },
                {"33", "Black" },
                {"21", "Red" },
                {"6", "Black" },
                {"18", "Red" },
                {"31", "Black" },
                {"19", "Red" },
                {"8", "Black" },
                {"12", "Red" },
                {"29", "Black" },
                {"25", "Red" },
                {"10", "Black" },
                {"27", "Red" },
                {"00", "Green" },
                {"1", "Red" },
                {"13", "Black" },
                {"36", "Red" },
                {"24", "Black" },
                {"3", "Red" },
                {"15", "Black" },
                {"34", "Red" },
                {"22", "Black" },
                {"5", "Red" },
                {"17", "Black" },
                {"32", "Red" },
                {"20", "Black" },
                {"7", "Red" },
                {"11", "Black" },
                {"30", "Red" },
                {"26", "Black" },
                {"9", "Red" },
                {"28", "Black" },
            };

            return ars;
        }


        /*******************************************
         * Sam as above, but the 2D array is sorted
         * by number.
         *******************************************/
        public static string[,] SortedArray()
        {
            string[,] ars = new string[38, 2]
            {
                { "0", "Green" },
                {"00", "Green" },
                {"1", "Red" },
                {"2", "Black" },
                {"3", "Red" },
                {"4", "Black" },
                {"5", "Red" },
                {"6", "Black" },
                {"7", "Red" },
                {"8", "Black" },
                {"9", "Red" },
                {"10", "Black" },
                {"11", "Black" },
                {"12", "Red" },
                {"13", "Black" },
                {"14", "Red" },
                {"15", "Black" },
                {"16", "Red" },
                {"17", "Black" },
                {"18", "Red" },
                {"19", "Red" },
                {"20", "Black" },
                {"21", "Red" },
                {"22", "Black" },
                {"23", "Red" },
                {"24", "Black" },
                {"25", "Red" },
                {"26", "Black" },
                {"27", "Red" },
                {"28", "Black" },
                {"29", "Black" },
                {"30", "Red" },
                {"31", "Black" },
                {"32", "Red" },
                {"33", "Black" },
                {"34", "Red" },
                {"35", "Black" },
                {"36", "Red" },
            };
            return ars;
        }


        /***********************************
         * A 1D array made up of number 
         * strings "1"-"36" "0" and "00".
         * Used to create the colors for 
         * the display.
         ***********************************/
        public static string[] Numbers()
        {
            string[] ars = new string[38]
            {
                 "0","00","1",
                 "2","3","4",
                 "5","6","7",
                 "8","9","10",
                 "11","12","13",
                 "14","15","16",
                 "17","18","19",
                 "20","21","22",
                 "23","24","25",
                 "26","27","28",
                 "29","30","31",
                 "32","33","34",
                 "35","36",
            };
            return ars;
        }


        /*****************************************
         * Used to create a variable for what the
         * ball will land on when you spin the 
         * wheel.
         *****************************************/
        public static string[,] BallNumber()
        {
            string[,] array = Bins.RandomArray();

            Random r = new Random();
            
            string[,] randomstring = new string[1,2];
            
            int rng = r.Next(38);

            randomstring[0, 0] = array[rng,0];
            randomstring[0, 1] = array[rng, 1];
            
            return randomstring;
        }


    }
}
