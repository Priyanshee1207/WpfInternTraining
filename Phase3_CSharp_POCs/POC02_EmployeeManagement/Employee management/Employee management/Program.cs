using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_management
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Employee Management System ===");
            Console.WriteLine("1. Add New Employee");
            Console.WriteLine("2. View All Employees");
            Console.WriteLine("3. Search Employee by ID");
            Console.WriteLine("4. Update Employee Details");
            Console.WriteLine("5. Delete Employee");
            Console.WriteLine("6 .EXIT");
            Console.WriteLine();

            
            
        }
    }
     public class Employee
    {
        public static int _idCounter = 1;
        public int Id;
        public string Name;
        public string Department;
        public decimal Salary;
        public DateTime JoiningDate;
    }
}
