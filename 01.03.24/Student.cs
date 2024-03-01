using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace _01._03._24
{
    class Student : Person
    {
        public int Course { get; set; }

        public Student(string fName, string lName, DateTime date, string faculity, int course)
            : base(fName, lName, date, faculity)
        {
            this.Course = course;
        }

        public override void Info()
        {
            WriteLine("Name: ", FName, LName);
            WriteLine("Birth Date: ", Date.ToShortDateString());
            WriteLine("Course: ", Course);
            WriteLine("Faculty: ", Faculity);
            WriteLine("Age: ", CalculateAge());
            WriteLine();
        }
    }
}
