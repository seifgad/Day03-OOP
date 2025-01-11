namespace Assigment
{
    public class HiringDate
    {
     
        private int day;
        private int month;
        private int year;

       
        public int Day
        {
            get { return day; }
            set
            {
                if (value >= 1 && value <= 31)
                {
                    day = value;
                }
                else
                {
                    throw new ArgumentException("Day must be between 1 and 31.");
                }
            }
        }

        public int Month
        {
            get { return month; }
            set
            {
                if (value >= 1 && value <= 12)
                {
                    month = value;
                }
                else
                {
                    throw new ArgumentException("Month must be between 1 and 12.");
                }
            }
        }

        public int Year
        {
            get { return year; }
            set
            {
                if (value > 0)
                {
                    year = value;
                }
                else
                {
                    throw new ArgumentException("Year must be a positive number.");
                }
            }
        }

       
        public HiringDate(int day, int month, int year)
        {
            Day = day;
            Month = month;
            Year = year;
        }

        
        public override string ToString()
        {
            return $"{Day:D2}/{Month:D2}/{Year}";
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1

            //try
            //{
            //    Employee employee = new Employee
            //    {
            //        ID = 200522,
            //        Name = "Seif Gad",
            //        SecurityPrivilege = SecurityLevel.Developer,
            //        Salary = 700.5m,
            //        HireDate = new DateTime(2020, 5, 15),
            //        Gender = "M"
            //    };

            //    Console.WriteLine("Employee Information:");
            //    Console.WriteLine(employee);
            //}
            //catch (ArgumentException ex)
            //{
            //    Console.WriteLine($"Error: {ex.Message}");
            //}
            #endregion

            #region Q2
            //try
            //{
            //    HiringDate hiringDate = new HiringDate(15, 5, 2020);

            //    Console.WriteLine($"Hiring Date: {hiringDate}");
            //}
            //catch (ArgumentException ex)
            //{
            //    Console.WriteLine($"Error: {ex.Message}");
            //}
            #endregion

            #region Q3
            //try
            //{
                
            //    Employee[] EmpArr = new Employee[3];

            //    EmpArr[0] = new Employee(101, "Alice", SecurityLevel.DBA, 85000m, new DateTime(2020, 6, 15), "F");
            //    EmpArr[1] = new Employee(102, "Bob", SecurityLevel.Guest, 35000m, new DateTime(2022, 3, 10), "M");
            //    EmpArr[2] = new Employee(103, "Charlie", SecurityLevel.SecurityOfficer, 95000m, new DateTime(2018, 1, 5), "M");

            //    Console.WriteLine("Employee Details:");
            //    foreach (var emp in EmpArr)
            //    {
            //        Console.WriteLine(emp);
            //    }
            //}
            //catch (ArgumentException ex)
            //{
            //    Console.WriteLine($"Error: {ex.Message}");
            //}
            #endregion


        }
    }
    }
