using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Victor_Jdanovitch_Lab04_Ex3
{
    class Employee
    {
        public string Name { get; set; }
        public double Salary { get; set; }

        public Employee(string name, double salary)
        {
            Name = name;
            Salary = salary;
        }

        public Employee() : this("J Hardy", 90000)
        {
        }

        public override string ToString()
        {
            return String.Format($"Name: {Name} || \tSalary:{Salary}");
        }
    }
}
