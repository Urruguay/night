using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace _09._02._24
{
    internal class Person
    {
        private int age;
        private string name;
        private string surname;

        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                age = value;
            }
        }
        public string Name 
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public string Surname
        {
            get
            {
                return surname;
            }
            set
            {
                surname = value;
            }
        }

        public Person(int age, string name, string surname)
        {
            Age = age;
            Name = name;
            Surname = surname;
        }
        public void Print()
        {
            WriteLine($"Имя: {Name}");
            WriteLine($"Фамилия: {Surname}");
            WriteLine($"Возраст: {Age}");
        }
    }
}
