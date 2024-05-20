using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace _01._03._24
{
    abstract class Person
    {
        public string FName { get; set; }
        public string LName { get; set; }
        public DateTime Date { get; set; }
        public string Faculity { get; set; }

        public Person() { }
        public Person(string fName, string lName, DateTime date, string faculity)
        {
            this.FName = fName;
            this.LName = lName;
            this.Date = date;
            this.Faculity = faculity;
        }

        public abstract void Info();

        public int Age()
        {
            DateTime currentDate = DateTime.Now;
            int age = currentDate.Year - Date.Year;
            if (currentDate < Date.AddYears(age))
            {
                age--;
            }
            return age;
        }
    }

}
