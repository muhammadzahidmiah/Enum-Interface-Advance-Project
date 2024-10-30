using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Enum___Interface.Enums;

namespace Enum___Interface.Models
{
    public class Department
    {
        public List<Department> departmentList = new List<Department>();
        public int Id { get; set; }
        public string Name { get; set; }
        public DepartmentType Type { get; set; }
        public DateTime EstablishedDate { get; set; } = DateTime.Now;
        public string Description { get; set; }
        public string Head { get; set; }
    }
}