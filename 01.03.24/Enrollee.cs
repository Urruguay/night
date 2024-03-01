using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace _01._03._24
{
    class Enrollee : Person
    {
        public Enrollee(string fName, string lName, DateTime date, string faculity)
        : base(fName, lName, date, faculity) { }
        public override void Info()
        {
            WriteLine("Name: ", FName, LName);
            WriteLine("Birth Date: ", Date.ToShortDateString());
            WriteLine("Age: ", CalculateAge());
            WriteLine("Faculty: ", Faculity);
            WriteLine();
        }
    }

}
