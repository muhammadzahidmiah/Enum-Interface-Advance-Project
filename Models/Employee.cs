using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Enum___Interface.Enums;

namespace Enum___Interface.Models
{
    public class Employee
    {
    public int EmployeeId { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Position { get; set; }
    public EmployeeType EmployeeType { get; set; }
    public DepartmentType DepartmentType { get; set; }
    }
}