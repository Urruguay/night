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
            new Enrollee("Иван", "Иванов", new DateTime(2000, 1, 1), "ФИТ"),
            new Student("Петр", "Петров", new DateTime(1998, 2, 1), "ФММ", 3),
            new Teacher("Мария", "Сидорова", new DateTime(1970, 3, 1), "ФЭН", "Доцент", 15)
            };

            // Вывод информации о каждой персоне из базы
            foreach (var person in people)
            {
                person.Info();
            }

            WriteLine();

            // Поиск персон по возрасту в заданном диапазоне
            Write("Введите минимальный возраст - ");
            int minAge = int.Parse(ReadLine());
            Write("Введите минимальный возраст - ");
            int maxAge = int.Parse(ReadLine());
            WriteLine($"Персоны в возрасте от {minAge} до {maxAge} лет:\n");

            foreach (var person in people)
            {
                int age = person.CalculateAge();
                if (age >= minAge && age <= maxAge)
                {
                    person.Name();
                }
            }

            Read();
        }
    }
}