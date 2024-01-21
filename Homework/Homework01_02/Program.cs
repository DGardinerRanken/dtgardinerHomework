using System;
using static System.Console;

namespace Homework01_02
{
    internal class Program
    {

        static void Main(string[] args)
        {
            string g1Str = "";
            string g2Str = "";
            string g3Str = "";
            string g4Str = "";
            int g1 = 0;
            int g2 = 0;
            int g3 = 0;
            int g4 = 0;
            int total;
            decimal avg;

            Write("Enter Grade 1:\t");
            g1Str = ReadLine();
            g1 = Int32.Parse(g1Str);

            Write("Enter Grade 2:\t");
            g2Str = ReadLine();
            g2 = Int32.Parse(g2Str);

            Write("Enter Grade 3:\t");
            g3Str = ReadLine();
            g3 = Int32.Parse(g3Str);

            Write("Enter Grade 4:\t");
            g4Str = ReadLine();
            g4 = Int32.Parse(g4Str);

            total = g1 + g2 + g3 + g4;

            avg = (decimal)total / 4;

            WriteLine("\nAverage Grade:\t" + avg.ToString("n2"));

            ReadLine();
        }
    }
}
