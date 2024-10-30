using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Enum___Interface.Models
{
    public interface IDepartment
    {
        public void Add(Department department);
        public void Update(Department department);
        public void Delete(int id, Department department);
        public Department Get(int id, Department department);
        public void GetAll(Department department);
        
    }
}