using System;
using System.ComponentModel;
using static System.Console;
using static System.Runtime.InteropServices.JavaScript.JSType;  

//7.  Write a console application that tracks the home sales of three salespeople (Danielle, Edward, Francis):
//●	The program prompts the user for a salesperson initial (d, e, or f) and the sales amount, then updates the total sales.
//●	Any user can have multiple sales.
//●	If the user enters "z" for the initial then the program should display the total sales for each three salesperson, the grand total for all sales, and the name of the salesperson with the highest total.

namespace Console
{
    internal class Program
    {

        //Declare and Initialize global variables

        static string salesInitialStr = "";
        static decimal dSales = 0m;
        static decimal eSales = 0m;
        static decimal fSales = 0m;
        static decimal dTotal = 0m;
        static decimal eTotal = 0m;
        static decimal fTotal = 0m;
        static string dSalesStr = "";
        static string eSalesStr = "";
        static string fSalesStr = "";
        static decimal grandTotal = 0m;

        static void Main(string[] args)
        {
            StartProgram();
        }

        static void StartProgram()
        {
            //Input Salespersons' initial

            Write("Please Enter a Salespersons' initial. (d, e, f, or z to display statistics): ");
            salesInitialStr = ReadLine();

            //Check for Initial

            if (salesInitialStr == "d")
            {
                Write("How Much Was Danielle's Sale?\t");
                dSalesStr = ReadLine();

                //Convert String to decimal

                dSales = Convert.ToDecimal(dSalesStr);

                //Add Sale to Total

                dTotal = dSales + dTotal;
                StartProgram();

            } else if (salesInitialStr == "e")
            {
                Write("How Much Was Edward's Sale?\t");
                eSalesStr = ReadLine();

                eSales = Convert.ToDecimal(eSalesStr);

                eTotal = eSales + eTotal;
                StartProgram();
            } else if (salesInitialStr == "f")
            {
                Write("How Much Was Francis' Sale?\t");
                fSalesStr = ReadLine();

                fSales = Convert.ToDecimal(fSalesStr);

                fTotal = fSales + fTotal;
                StartProgram();
            } else if (salesInitialStr == "z") 
            {
                grandTotal = (dTotal + eTotal + fTotal);

                WriteLine($"Danielle's Sales:   ${dTotal:n2}");
                WriteLine($"Edwards's Sales:    ${eTotal:n2}");
                WriteLine($"Francis' Sales:     ${fTotal:n2}");
                WriteLine($"Grand Total:        ${grandTotal}");

                if (dTotal > eTotal && dTotal > fTotal)
                {
                    WriteLine("Daneille has the most sales.");
                } else if (eTotal > dTotal && eTotal > fTotal)
                {
                    WriteLine("Edward has the most sales.");
                } else if (fTotal > dTotal && fTotal > eTotal)
                {
                    WriteLine("Francis has the most sales.");
                }
            }
               
                

           
        }
    }
}