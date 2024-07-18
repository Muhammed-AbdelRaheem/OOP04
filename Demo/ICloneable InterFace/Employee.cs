using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.ICloneable_InterFace
{
    internal class Employee : ICloneable, IComparable
    {

        public int Id { get; set; }
        public string? Name { get; set; }
        public decimal Salary { get; set; }

        public object Clone()
        {
            return new Employee()
            {
                Id = Id,
                Name = Name,
                Salary = Salary
            };
        }

        public int CompareTo(object? obj)
        {
            Employee PassedEmployee = (Employee)obj;
            if (this.Salary > PassedEmployee.Salary)
            {
                return 1;
            }
            else if (this.Salary < PassedEmployee.Salary)
            {
                return -1;
            }
            else { return 0; }

        }

        public override string ToString()
        {
            return $"id = {Id} , Name = {Name}, Salary = {Salary}";
        }



    }
}
