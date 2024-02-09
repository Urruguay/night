
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace _26._01._24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Ввод первой даты
            WriteLine("Введите первую дату (в формате ГГГГ-ММ-ДД):");
            if (!DateTime.TryParse(ReadLine(), out DateTime firstDate))
            {
                WriteLine("Некорректный формат даты. Попробуйте снова.");
                return;
            }

            // Ввод второй даты
            WriteLine("Введите вторую дату (в формате ГГГГ-ММ-ДД):");
            if (!DateTime.TryParse(ReadLine(), out DateTime secondDate))
            {
                WriteLine("Некорректный формат даты. Попробуйте снова.");
                return;
            }

            // Определение разницы между датами
            TimeSpan difference = secondDate - firstDate;

            // Вывод результата
            WriteLine($"Между датами прошло {difference.TotalDays} дней.");
            Read();
        }
    }
}
