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
        public string Faculty { get; set; }
        public Enrollee(string fName, string lName, DateTime date, string faculity)
        : base(fName, lName, date, faculity) { }

        // Реализация метода для вывода информации
        public override void Info()
        {
            WriteLine($"Applicant: {FName} {LName}, Age: {Age()}, Faculty: {Faculty}");
        }
    }

}
