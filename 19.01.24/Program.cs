using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Console;

namespace _19._01._24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //object[] arr = new object[6];
            //arr[0] = 1.879;
            //arr[1] = -7;
            //arr[2] = 'g';
            //arr[3] = "hello";
            //arr[4] = null;
            //arr[5] = new object();

            //WriteLine("Array elements:");

            //foreach (var item in arr)
            //{
            //    WriteLine(item);
            //}

            // Пример использования классов
            int n = 2; // Задайте количество школьников и спортсменов

            // Создание массивов объектов
            Students[] students = new Students[n];

            for (int i = 0; i < n; i++)
            {
                WriteLine($"Enter information for student {i + 1}:");
                Write("Full Name: ");
                string fName = ReadLine();
                Write("Gender (M or W): ");
                //char gender = char.ToUpper(ReadKey().KeyChar);
                char gen = char.Parse(ReadLine());
                //WriteLine(); // Переход на новую строку
                Write("Birth Year: ");
                int year = int.Parse(ReadLine());

                students[i] = new Students(fName, gen, year);

                try
                {
                    WriteLine($"Name: {fName}, Gender: {gen}, Birth Year: {year}");
                }
                catch (ArgumentException e)
                {
                    WriteLine($"Ошибка при вводе данных: {e.Message}");
                    i--;  // Позволяет пользователю повторно ввести данные
                }
            }

            //// Ввод информации по школьникам
            //for (int i = 0; i < n; i++)
            //{
            //    WriteLine($"Enter information for student {i + 1}:");
            //    Write("Full Name: ");
            //    string fName = ReadLine();
            //    Write("Gender (M or W): ");
            //    //char gender = char.ToUpper(ReadKey().KeyChar);
            //    char gen = char.Parse(ReadLine());
            //    WriteLine(); // Переход на новую строку
            //    Write("Birth Year: ");
            //    int year = int.Parse(ReadLine());

            //    students[i] = new Students(fName, gen, year);
            //}
            // Вывод информации о школьниках
            int bCount = 0;
            int gCount = 0;
            WriteLine("\nList of students:");
            foreach (var student in students)
            {

                // Подсчет количества мальчиков и девочек
                if (student.Gen == 'M')
                {
                    bCount++;
                }
                else if (student.Gen == 'W' )
                {
                    gCount++;
                }
            }
            
            // Вывод количества мальчиков и девочек
            WriteLine($"\nNumber of boys: {bCount}");
            WriteLine($"Number of girls: {gCount}");
            Read();
        }
    }
}
