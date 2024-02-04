using System;
using static System.Console;

//10. Write a console-based program that prints out a multiplication table.

//● Prompt the user for the number of rows.

//● Prompt the user for the number of columns.

//● Display a multiplication table for the numbers 1..rows by 1..cols

namespace Console
{
    internal class Program
    {

        //Declare and Initialize global variables

        static string ColumnsStr = "";
        static string RowsStr = "";
        static int Columns = 0;
        static int Rows = 0;

        static void Main(string[] args)
        {
            AskForDimensions();
        }
        static void AskForDimensions()
        {
            Write("Please Enter the Number of Rows for the Multiplication Table: ");
            ColumnsStr = ReadLine();

            Write("Please Enter the Number of Columns for the Multiplication Table: ");
            RowsStr = ReadLine();

            MultiplicationTable();
        }
        static void MultiplicationTable()
        {
            Columns = Convert.ToInt16(ColumnsStr);

            Rows = Convert.ToInt16(RowsStr);

            //I tried thinking this one out but I really do not think I understand the logic of it
        }
    }
}