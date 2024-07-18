using Demo.ICloneable_InterFace;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    internal class EmployeeIdComparer : IComparer
    {
        public int Compare(object? x, object? y)
        {
            Employee? employeeX = (Employee?)x;
            Employee? employeeY = (Employee?)x;

            return employeeX?.Id.CompareTo(employeeY?.Id) ?? (employeeY == null ? 0 : -1);

        }
    }
}
