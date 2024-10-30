using System;
using System.Collections.Generic;
using System.Linq;
using Enum___Interface.Models;

namespace Enum___Interface.Services
{
    public class EmployeeServices : IEmployee
    {
        private List<Employee> employeeList = new List<Employee>();

        public void Add(Employee employee)
        {
            if (!IsEmployeeValid(employee))
            {
                throw new ArgumentException("Invalid employee.");
            }
            
            // Check for duplicate EmployeeId
            if (employeeList.Any(e => e.EmployeeId == employee.EmployeeId))
            {
                throw new InvalidOperationException("Employee with the same ID already exists.");
            }

            employeeList.Add(employee);
        }

        public void Update(Employee employee)
        {
            if (!IsEmployeeValid(employee))
            {
                throw new ArgumentException("Invalid employee.");
            }

            var index = employeeList.FindIndex(x => x.EmployeeId == employee.EmployeeId);
            if (index < 0)
            {
                throw new KeyNotFoundException("Employee not found. Cannot update.");
            }

            employeeList[index] = employee;
        }

        public void Delete(int id)
        {
            IdCheck(id);
            var index = employeeList.FindIndex(x => x.EmployeeId == id);
            if (index < 0)
            {
                throw new KeyNotFoundException("Employee not found. Cannot delete.");
            }

            employeeList.RemoveAt(index);
        }

        public Employee Get(int id)
        {
            IdCheck(id);
            var employee = employeeList.FirstOrDefault(x => x.EmployeeId == id);
            if (employee == null)
            {
                throw new KeyNotFoundException("Employee not found.");
            }
            return employee;
        }

        public void GetAll()
        {
           if (employeeList != null && employeeList.Any())
        {
            employeeList.ForEach(x => Console.WriteLine(x));
        }
        else
        {
            Console.WriteLine("No departments available.");
        }
        }

        public bool IsEmployeeValid(Employee employee)
        {
            if (employee == null) throw new ArgumentNullException(nameof(employee));
            if (employee.EmployeeId <= 0) throw new ArgumentException("Employee ID must be a positive integer.", nameof(employee.EmployeeId));
            if (string.IsNullOrWhiteSpace(employee.FirstName)) throw new ArgumentNullException(nameof(employee.FirstName), "Employee First Name cannot be null or empty.");
            if (string.IsNullOrWhiteSpace(employee.LastName)) throw new ArgumentNullException(nameof(employee.LastName), "Employee Last Name cannot be null or empty.");
            if (string.IsNullOrWhiteSpace(employee.Position)) throw new ArgumentNullException(nameof(employee.Position), "Employee Position cannot be null or empty.");
            return true;
        }

        public void IdCheck(int id)
        {
            if (id <= 0) throw new ArgumentException("ID must be a positive integer.", nameof(id));
        }

        public bool IsListValid(List<Employee> employees)
        {
            if (employees == null) throw new ArgumentNullException(nameof(employees), "Employee list cannot be null.");
            if (!employees.Any()) throw new ArgumentException("Employee list cannot be empty.", nameof(employees));

            foreach (var employee in employees)
            {
                IsEmployeeValid(employee); // Use IsEmployeeValid to check each employee's validity.
            }
            return true;
        }
    }
}
