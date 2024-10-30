using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Enum___Interface.Models
{
    public interface IEmployee
    {
    void Add(Employee employee );
    void Update(Employee employee);
    void Delete(int id);
    Employee Get(int id);
    void GetAll();
    }
}