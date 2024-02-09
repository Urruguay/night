using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;


namespace _09._02._24
{
    internal class Employee : Person
    {
        private string company;
        private string job;

        public string Company
        {
            get { return company; }
            set { company = value; }
        }
        public string Job
        {
            get { return job; }
            set { job = value; }
        }

        public Employee(int age, string name, string surname, string company, string job) : base(age, name, surname)
        {
            Company = company;
            Job = job;
        }

        public new void Print()
        {
            base.Print();
            WriteLine($"Компания: {Company}");
            WriteLine($"Должность: {Job}");
        }
    }
}
