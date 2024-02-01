using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace _22._01._2024
{
    internal class Program
    {
        static void Main()
        {
            while (true)
            {
                ConsoleColor originalColor = ForegroundColor;
                ForegroundColor = ConsoleColor.Green;

                WriteLine("1. Вывести информацию о текущей дате и времени");
                WriteLine("2. Ввести возраст и вывести год рождения");
                WriteLine("3. Определить возраст");
                Write("Выберите задачу: ");
                ForegroundColor = originalColor;

                int choice;
                if (int.TryParse(ReadLine(), out choice))
                {
                    switch (choice)
                    {
                        case 1:
                            ADateTime();
                            break;
                        case 2:
                            BirthYear();
                            break;
                        case 3:
                            CalculateAge();
                            break;
                        default:
                            ForegroundColor = ConsoleColor.Red;
                            WriteLine("Пожалуйста, введите число от 1 до 3.");
                            ForegroundColor = originalColor;
                            break;
                    }
                }
                else
                {
                    WriteLine("Неверный ввод. Пожалуйста, введите число.");
                }
                ForegroundColor = ConsoleColor.Magenta;
                Write("\nЖелаете выполнить еще одну задачу? (y/n)");
                ForegroundColor = originalColor;
                WriteLine();
                if (ReadLine().ToLower() != "y")
                    break;
            }
        }

        static void ADateTime()
        {
            //Задание 1. Вывести сообщение с информацией о текущей системной дате,
            //применив несколько форматов.
            DateTime dt = new DateTime(2022, 1, 20, 13, 5, 20);
            WriteLine();
            WriteLine("Текущая дата:");
            WriteLine(dt.ToString("d")); //20.01.2022
            WriteLine(dt.ToString("d MMM yyyy")); //20 янв. 2022
            WriteLine(dt.ToString("d MMMM yyyyг.")); //20 января 2022г.
            WriteLine(dt.ToString("ddd, dd MMM yyyy")); //Чт, 20 янв. 2022
            WriteLine(dt.ToString("D")); //четверг, 20 января 2022
            WriteLine();
            WriteLine("Текущее время:");
            WriteLine(dt.ToString("T")); //13:05:20
            WriteLine(dt.ToString("t")); //13:05
            WriteLine();
            WriteLine("Текущая дата и время:");
            WriteLine(dt.ToString("G")); //20.01.2022 13:05:20
            WriteLine(dt.ToString("d MMMM yyyyг. H:mm")); //20 января 2022г. 13:05
            WriteLine(dt.ToString("d MMMM yyyyг. H:mm:ss")); //20 января 2022г. 13:05:20
            WriteLine(dt.ToString("R")); //Thu, 20 Jan 2022 13:05:20 GMT
            WriteLine(dt.ToString("s")); //2022-01-20T13:05:20
        }

        static void BirthYear()
        {
            ConsoleColor originalColor = ForegroundColor;
            // Задание 2. Запросить с клавиатуры возраст человека и вывести
            // на экран следующее сообщение: Ты родился в .... году
            Write("Введите свой возраст: ");
            if (int.TryParse(ReadLine(), out int age))
            {
                int Year = DateTime.Now.Year;
                int birthYear = Year - age;

                WriteLine($"Ты родился в {birthYear} году");
            }
            else
            {
                ForegroundColor = ConsoleColor.Red;
                WriteLine("Неверный ввод. Возраст должен быть числом.");
                ForegroundColor = originalColor;
            }
        }

        static void CalculateAge()
        {
            ConsoleColor originalColor = ForegroundColor;
            // Ваш код для запроса года рождения и вывода возраста

            Write("Введите год рождения: ");
            if (int.TryParse(ReadLine(), out int birthYear))
            {
                int Year = DateTime.Now.Year;
                int age = Year - birthYear;

                WriteLine($"Ваш возраст: {age} лет");
            }
            else
            {
                ForegroundColor = ConsoleColor.Red;
                WriteLine("Неверный ввод");
                ForegroundColor = originalColor;
            }
        }
    }
}
