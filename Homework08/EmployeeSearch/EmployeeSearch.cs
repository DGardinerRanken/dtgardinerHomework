using System;
using System.Collections.Generic;
using static System.Console;
using System.Linq;


namespace EmployeeSearch
{
    internal class EmployeeSearch
    {
        //Declare and Initialize global constants
        const string NOTHINGINPUTTED = "No Input Detected For Search Criteria";
        const string NOLASTNAMEFOUND = "No Matching Employee Last Name Found";
        const string NOADDRESSFOUND = "No Matching Employee Address Found";
        const string NOCITYFOUND = "No Matching Employee City Found";
        const string NOSTATEFOUND = "No Matching Employee State Found";
        const string NOZIPCODEFOUND = "No Matching Employee Zip Code Found";

        //Declare and Initialize class variable
        static List<Employee> employees = EmployeeManager.LoadData();
        static void Main(string[] args)
        {
            int option;
            bool runAgain = true;

            while (runAgain)
            {
                option = ShowMenu();
                CallCorrectFunction(option);
                runAgain = AnotherTime();
            }
        }

        static int ShowMenu()
        {
            Clear();

            string o = string.Empty;
            int optionChosen = 0;
            bool result;

            //Menu
            string menuStr = "Please choose one of the following options:\n";
            menuStr += "Enter a 1 to show all employees last name ascending\n";
            menuStr += "Enter a 2 to show all employees address ascending\n";
            menuStr += "Enter a 3 to show all employees city ascending\n";
            menuStr += "Enter a 4 to show all employees state ascending\n";
            menuStr += "Enter a 5 to show all employees zipcode ascending\n";
            menuStr += "Enter a 6 to show one or more employees by last name\n";
            menuStr += "Enter a 7 to show one or more employees by address\n";
            menuStr += "Enter a 8 to show one or more employees by city\n";
            menuStr += "Enter a 9 to exit the program now\n\n";
            menuStr += "Please enter a 1, 2, 3, 4, 5, 6, 7, 8, or 9: ";

            Write(menuStr);
            o = ReadLine();

            //Validate the entry was valid (1-9)
            result = int.TryParse(o, out optionChosen);

            //Parse failed
            if (!result)
            {
                Write("You Must Enter a Number. Please Try Again: ");
                ReadLine();
                ShowMenu();
            }

            else if (optionChosen < 1 || optionChosen > 9)
            {
                Write("You Must Enter a Number Between 1 & 9. Please Try Again: ");
                ReadLine();
                ShowMenu();
            }
            return optionChosen;
        }

        static void CallCorrectFunction(int o)
        {
            switch (o)
            {
                case 1:
                    ShowEmployeesByLastNameAscending();
                    break;
                case 2:
                    ShowEmployeesByAddressAscending();
                    break;
                case 3:
                    ShowEmployeesByCityAscending();
                    break;
                case 4:
                    ShowEmployeesByStateAscending();
                    break;
                case 5:
                    ShowEmployeesByZipCodeAscending();
                    break;
                case 6:
                    ShowEmployeesByLastNameCriteria();
                    break;
                case 7:
                    ShowEmployeesByAddressCriteria();
                    break;
                case 8:
                   ShowEmployeesByCityCriteria();
                    break;
                case 9:
                    ExitProgramNow();
                    break;
                default:
                    break;
            }
        }

        static void ShowEmployeesByLastNameAscending()
        {
            Clear();

            var lastNameAscending = 
                from e in employees
                orderby e.LastName ascending, e.FirstName ascending
                select e;

            WriteLine("All Employees By Last Name In Ascending Order: \n");
            foreach(var e in lastNameAscending)
            {
                WriteLine(e);
            }
            
            ReadLine();
        }

        static void ShowEmployeesByAddressAscending()
        {
            Clear();

            var addressAscending =
                from e in employees
                orderby e.Address, e.LastName ascending, e.FirstName ascending
                select e;

            WriteLine("All Employees By Address In Ascending Order: \n");
            foreach (var e in addressAscending)
            {
                WriteLine(e);
            }

            ReadLine();
        }

        static void ShowEmployeesByCityAscending()
        {
            Clear();

            var cityAscending =
                from e in employees
                orderby e.City, e.LastName ascending, e.FirstName ascending
                select e;

            WriteLine("All Employees By City In Ascending Order: \n");
            foreach (var e in cityAscending)
            {
                WriteLine(e);
            }

            ReadLine();
        }

        static void ShowEmployeesByStateAscending()
        {
            Clear();

            var stateAscending =
                from e in employees
                orderby e.State, e.City ascending, e.LastName ascending, e.FirstName ascending
                select e;

            WriteLine("All Employees By State In Ascending Order: \n");
            foreach (var e in stateAscending)
            {
                WriteLine(e);
            }

            ReadLine();
        }

        static void ShowEmployeesByZipCodeAscending()
        {
            Clear();

            var zipCodeAscending =
                from e in employees
                orderby e.ZipCode, e.State, e.City, e.LastName ascending, e.FirstName ascending
                select e;

            WriteLine("All Employees By Zip Code In Ascending Order: \n");
            foreach (var e in zipCodeAscending)
            {
                WriteLine(e);
            }

            ReadLine();
        }

        static void ShowEmployeesByLastNameCriteria()
        {
            Clear();

            string lastName;

            Write("Enter an employee last name to search for (Full or partial): ");
            lastName = ReadLine();

            if (lastName.Trim() == "")
            {
                WriteLine(NOTHINGINPUTTED);
                ReadLine();
            }
            else
            {
                var lastNames =
                    from e in employees
                    orderby e.LastName ascending
                    where e.LastName.ToUpper().Contains(lastName.ToUpper())
                    select e;

                WriteLine("\nLast Names Matching Inputted Criteria: ");
                if (lastNames.Count() < 1)
                {
                    WriteLine(NOLASTNAMEFOUND);
                    ReadLine();
                    return;
                }
                foreach (var ln in lastNames)
                {
                    WriteLine(ln);
                    ReadLine();
                }
            }
        }
        static void ShowEmployeesByAddressCriteria()
            {
                Clear();

                string address;

                Write("Enter an employee Address to search for (Full or partial): ");
                address = ReadLine();

                if (address.Trim() == "")
                {
                    WriteLine(NOTHINGINPUTTED);
                    ReadLine();
                }
                else
                {
                    var addresses =
                        from e in employees
                        orderby e.LastName ascending
                        where e.Address.ToUpper().Contains(address.ToUpper())
                        select e;

                    WriteLine("\nAddresses Matching Inputted Criteria: ");
                    if (addresses.Count() < 1)
                    {
                        WriteLine(NOADDRESSFOUND);
                        ReadLine();
                        return;
                    }
                    foreach (var ln in addresses)
                    {
                        WriteLine(ln);
                        ReadLine();
                    }
                }
            }

        static void ShowEmployeesByCityCriteria()
        {
            Clear();

            string city;

            Write("Enter an employee City to search for (Full or partial): ");
            city = ReadLine();

            if (city.Trim() == "")
            {
                WriteLine(NOTHINGINPUTTED);
                ReadLine();
            }
            else
            {
                var cities =
                    from e in employees
                    orderby e.City ascending
                    where e.City.ToUpper().Contains(city.ToUpper())
                    select e;

                WriteLine("\nCity Matching Inputted Criteria: ");
                if (cities.Count() < 1)
                {
                    WriteLine(NOCITYFOUND);
                    ReadLine();
                    return;
                }
                foreach (var ln in cities)
                {
                    WriteLine(ln);
                    ReadLine();
                }
            }
        }

        static void ExitProgramNow()
        {
            Clear();

            WriteLine("Program Terminating Normally. Bye for now.");
            ReadLine();

            Environment.Exit(0);
        }

        static bool AnotherTime()
        {
            bool retVal = true;

            string again = "";
            char firstChar = ' ';

            Write("Run Program Again? (Y/N): ");
            again = ReadLine().ToUpper();

            firstChar = again[0];

            if (firstChar != 'Y')
            {
                retVal = false; 
            }
            return retVal;
        }
    }
}
