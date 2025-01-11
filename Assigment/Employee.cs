using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assigment
{
    internal class Employee
    {

        // Private fields
        private string gender;
        private decimal salary;

        // Properties with validation
        public int ID { get; set; }
        public string Name { get; set; }
        public SecurityLevel SecurityPrivilege { get; set; }

        public decimal Salary
        {
            get { return salary; }
            set
            {
                if (value >= 0)
                {
                    salary = value;
                }
                else
                {
                    throw new ArgumentException("Salary cannot be negative.");
                }
            }
        }

        public DateTime HireDate { get; set; }

        public string Gender
        {
            get { return gender; }
            set
            {
                if (value == "M" || value == "F")
                {
                    gender = value;
                }
                else
                {
                    throw new ArgumentException("Gender must be 'M' (Male) or 'F' (Female).");
                }
            }
        }

        // Constructors
        public Employee(int id, string name, SecurityLevel privilege, decimal salary, DateTime hireDate, string gender)
        {
            ID = id;
            Name = name;
            SecurityPrivilege = privilege;
            Salary = salary;
            HireDate = hireDate;
            Gender = gender; // Validated through property
        }

        public Employee() : this(0, "Unknown", SecurityLevel.Guest, 0, DateTime.Now, "M") { }

        // Method to display employee details
        public override string ToString()
        {
            return $"ID: {ID}, Name: {Name}, Security Level: {SecurityPrivilege}, Gender: {(Gender == "M" ? "Male" : "Female")}, Salary: {String.Format(CultureInfo.CurrentCulture, "{0:C}", Salary)}, Hire Date: {HireDate:yyyy-MM-dd}";
        }
    }
}
}
