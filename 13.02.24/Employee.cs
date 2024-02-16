using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace _13._02._24
{
    class Employee
    {
        private string firstName;
        private string lastName;
        private DateTime dateb;
        private double baseSalary;

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }
        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }
        public DateTime Dateb
        {
            get { return dateb; }
            set { dateb = value; }
        }
        public double BaseSalary
        {
            get { return baseSalary; }
            set { baseSalary = value; }
        }

        public Employee()
        {
            firstName = "Неизвестно";
            lastName = "";
            dateb = DateTime.Now;
            baseSalary = 0;
        }
        public Employee(string firstName, string lastName, DateTime dateb, double baseSalary)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.dateb = dateb;
            this.baseSalary = baseSalary;
        }
        public virtual double Calc(double coeff)
        {
            return baseSalary * coeff;
        }
        public void Info()
        {
            WriteLine($"Name - {firstName} {lastName}\n" +
                $"Date of Birth - {dateb.ToShortDateString()}\n" +
                $"Base Salary - {baseSalary}");
        }
    }
}
