using System;
using static System.Console;

namespace Homework01_01
{
    internal class Program
    {

        //Declare and initialize constants

        const decimal KM_PER_MILE = 1.6m;
        static void Main(string[] args)
        {
            string milesStr = "";
            decimal miles = 0;
            decimal kilos = 0;

            Write("Enter number of miles:\t");
            milesStr = ReadLine();

            miles = Decimal.Parse(milesStr);
            kilos = miles * KM_PER_MILE;

            WriteLine("\n" + miles + " miles is " + kilos + " kilometers");

            ReadLine();
        }
    }
}
