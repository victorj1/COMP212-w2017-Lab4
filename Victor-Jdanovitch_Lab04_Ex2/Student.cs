using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Victor_Jdanovitch_Lab04_Ex2
{
    class Student
    {
        public string ID { get; set; }
        public string Name { get; set; }

        public Student(string ID, string Name)
        {
            this.ID = ID;
            this.Name = Name;
        }

        public Student() : this("1", "J Hardy")
        {
        }

        public override string ToString()
        {
            return String.Format($"ID: {ID} --> Name:{Name}");
        }
    }
}
