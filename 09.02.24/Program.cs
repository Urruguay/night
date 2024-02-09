using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace _09._02._24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. Создать объект базового класса и обратиться к методу вывода состояния объекта базового класса
            Person person = new Person(30, "Иван", "Иванов");
            WriteLine("Информация о персоне:");
            person.Print();
            WriteLine();

            // 2. Создать объект производного класса и обратиться к методу вывода информации о сотруднике производного класса
            Employee employee = new Employee(25, "Петр", "Петров", "ООО Рога и копыта", "Программист");
            WriteLine("Информация о сотруднике:");
            employee.Print();
            WriteLine();

            // 3. Создать ссылку типа базового класса на объект производного класса и обратиться к методу вывода состояния объекта базового класса
            Person derivedPerson = new Employee(35, "Сидор", "Сидоров", "ООО Мегафон", "Менеджер");
            WriteLine("Информация о персоне через ссылку на базовый класс:");
            derivedPerson.Print();

            Read();
        }
    }
}
