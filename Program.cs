using Enum___Interface.Models;
using Enum___Interface.Services;

namespace Enum___Interface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Department department = new Department();
            DepartmentServices departmentServices = new DepartmentServices();
            Employee employee = new Employee();
            EmployeeServices employeeServices = new EmployeeServices();
            var employee1 = new Employee
            {
                EmployeeId = 1,
                FirstName = "John",
                LastName = "Doe",
                Position = "Software Engineer"
            };

            var employee2 = new Employee
            {
                EmployeeId = 2,
                FirstName = "Jane",
                LastName = "Smith",
                Position = "Project Manager"
            };

            // Add employees
            try
            {
                employeeServices.Add(employee1);
                employeeServices.Add(employee2);
                Console.WriteLine("Employees added successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error adding employee: {ex.Message}");
            }
            
        }
    }
}