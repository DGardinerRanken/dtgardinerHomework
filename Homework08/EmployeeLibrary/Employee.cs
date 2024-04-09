using System;


namespace EmployeeSearch
{
    public class Employee
    {
        //Instance Variables
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string SocSecNumber { get; set;}
        public string Address { get; set;}
        public string City { get; set;}
        public string State { get; set;}
        public string ZipCode { get; set;}

        //Override the ToString() method
        public override string ToString()
        {
            return "First Name: " + FirstName + 
                    "Last Name: " + LastName +
                    "Soc Sec Number: " + SocSecNumber + 
                    "Address: " + Address +
                    "City: " + City + 
                    "State: " + State + 
                    "Zip Code: " + ZipCode;
        }
    }
}
