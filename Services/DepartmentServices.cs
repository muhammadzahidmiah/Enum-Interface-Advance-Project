using System;
using System.Collections.Generic;
using System.Linq;
using Enum___Interface.Models;

namespace Enum___Interface.Services
{
    public class DepartmentServices : IDepartment
    {
        // Adding a department to the department's internal list
        public void Add(Department department)
        {
            if (IsDepartmentValid(department))
            {
                department.departmentList.Add(department);
            }
            else
            {
                Console.WriteLine("Invalid department. Cannot add.");
            }
        }

        public void Update(Department department)
        {
            if (IsDepartmentValid(department))
            {
                var index = department.departmentList.FindIndex(x => x.Id == department.Id);
                if (index >= 0) // Check if the department exists
                {
                    department.departmentList[index] = department;
                }
                else
                {
                    Console.WriteLine("Department not found. Cannot update.");
                }
            }
            else
            {
                Console.WriteLine("Invalid department. Cannot update.");
            }
        }

        public void Delete(int id, Department department)
        {
            if (IdCheck(id))
            {
                var index = department.departmentList.FindIndex(x => x.Id == id);
                if (index >= 0) // Check if the department exists
                {
                    department.departmentList.RemoveAt(index);
                }
                else
                {
                    Console.WriteLine("Department not found. Cannot delete.");
                }
            }
        }

        public Department Get(int id, Department department)
        {
            if (IdCheck(id))
            {
                var foundDepartment = department.departmentList.FirstOrDefault(x => x.Id == id);
                if (foundDepartment != null)
                {
                    return foundDepartment;
                }
                Console.WriteLine("Department not found.");
            }
            return null;
        }

        public void GetAll(Department department)
        {
            if (department.departmentList != null && department.departmentList.Any())
            {
                department.departmentList.ForEach(x => Console.WriteLine(x));
            }
            else
            {
                Console.WriteLine("No departments available.");
            }
        }

        public bool IsDepartmentValid(Department department)
        {
            if (department == null)
            {
                throw new ArgumentNullException(nameof(department));
            }
            if (department.Id <= 0)
            {
                throw new ArgumentException("Department ID must be a positive integer.", nameof(department.Id));
            }
            if (string.IsNullOrWhiteSpace(department.Name))
            {
                throw new ArgumentNullException(nameof(department.Name), "Department Name cannot be null or empty.");
            }
            return true;
        }

        public bool IdCheck(int id)
        {
            if (id <= 0)
            {
                throw new ArgumentException("ID must be a positive integer.", nameof(id));
            }
            return true;
        }
    }
}
