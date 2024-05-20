using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace _01._03._24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Создание базы из набора персон
            List<Person> people = new List<Person>
            {
            new Enrollee("John", "Doe", new DateTime(2000, 5, 15), "Lawyer"),
            new Student("Jane", "Smith", new DateTime(2001, 8, 20), "Mathematics", 2),
            new Teacher("Michael", "Johnson", new DateTime(1980, 3, 10), "Physics", "Professor", 15)
            };

            // Вывод информации о каждой персоне из базы
            foreach (var person in people)
            {
                person.Info();
            }

            // Поиск персон по возрасту в заданном диапазоне
            int minAge = 20;
            int maxAge = 30;
            WriteLine($"Люди в возрасте от {minAge} до {maxAge} лет:");
            foreach (var person in people)
            {
                int age = person.CalculateAge();
                if (age >= minAge && age <= maxAge)
                {
                    person.Info();
                }
            }
            Read();
        }
    }
}
