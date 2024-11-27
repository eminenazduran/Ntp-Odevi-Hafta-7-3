namespace Enum3
{
    using System;

    enum EmployeeRole
    {
        Manager,
        Developer,
        Designer,
        Tester
    }

    class SalaryCalculator
    {
        public static void CalculateSalary(EmployeeRole role)
        {
            decimal salary = 0;

            switch (role)
            {
                case EmployeeRole.Manager:
                    salary = 8000;
                    break;
                case EmployeeRole.Developer:
                    salary = 6000;
                    break;
                case EmployeeRole.Designer:
                    salary = 5000;
                    break;
                case EmployeeRole.Tester:
                    salary = 4000;
                    break;
                default:
                    Console.WriteLine("Invalid role.");
                    return;
            }

            Console.WriteLine($"The salary for the {role} is: ${salary}");
        }
    }

    class Program
    {
        static void Main()
        {
            EmployeeRole employeeRole = EmployeeRole.Developer;
            SalaryCalculator.CalculateSalary(employeeRole); // Output: The salary for the Developer is: $6000
        }
    }

}
