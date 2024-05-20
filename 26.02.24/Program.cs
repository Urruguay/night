using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace _26._02._24
{
    class Program
    {
        static List<Figure> figures = new List<Figure>();
        static void Main(string[] args)
        {
                bool exit = false;
            while (!exit)
            {
                ForegroundColor = ConsoleColor.Yellow;
                WriteLine("Выберите действие:");
                WriteLine("1. Добавить квадрат");
                WriteLine("2. Добавить треугольник");
                WriteLine("3. Добавить круг");
                WriteLine("4. Просмотреть список фигур");
                WriteLine("5. Просмотреть информацию о фигуре");
                WriteLine("6. Редактировать фигуру");
                WriteLine("7. Удалить фигуру");
                WriteLine("8. Вызвать метод фигуры");
                WriteLine("9. Выход");
                ResetColor();
                int choice;
                if (!int.TryParse(Console.ReadLine(), out choice))
                {
                    WriteLine("Некорректный ввод. Повторите попытку");
                    continue;
                }

                switch (choice)
                {
                    case 1:
                         AddSquare();
                         break;
                    case 2:
                         AddTriangle();
                         break;
                    case 3:
                         AddCircle();
                         break;
                    case 4:
                         ViewFiguresList();
                         break;
                    case 5:
                         ViewFigureInfo();
                         break;
                    case 6:
                         EditFigure();
                         break;
                    case 7:
                         DeleteFigure();
                         break;
                    case 8:
                         CallFigureMethod();
                         break;
                    case 9:
                         exit = true;
                         break;
                    default:
                         WriteLine("Некорректный выбор. Повторите попытку");
                         break;
                }
            }
        }

        static void AddSquare()
        {
            Write("Введите имя квадрата:  ");
            string name = ReadLine();

            Write("Введите сторону квадрата:  ");
            if (!double.TryParse(Console.ReadLine(), out double side))
            {
                WriteLine("Некорректный ввод для стороны квадрата");
                return;
            }

             Square square = new Square(side, name);
             figures.Add(square);

             WriteLine("Квадрат был добавлен)");
        }

        static void AddTriangle()
        {
            Console.WriteLine("Введите имя треугольника:");
            string name = Console.ReadLine();

            Console.WriteLine("Введите стороны треугольника (через пробел):");
            string[] sides = Console.ReadLine().Split(' ');
            if (sides.Length != 3 || !double.TryParse(sides[0], out double side1) || !double.TryParse(sides[1], out double side2) || !double.TryParse(sides[2], out double side3))
            {
                Console.WriteLine("Некорректный ввод для сторон треугольника.");
                return;
            }

            Triangle triangle = new Triangle(side1, side2, side3, name );
            figures.Add(triangle);
            Console.WriteLine("Треугольник добавлен.");
        }

        static void AddCircle()
        {
            Console.WriteLine("Введите имя круга:");
            string name = Console.ReadLine();

            Console.WriteLine("Введите радиус круга:");
            if (!double.TryParse(Console.ReadLine(), out double radius))
            {
                Console.WriteLine("Некорректный ввод для радиуса круга.");
                return;
            }

            Circle circle = new Circle(radius, name);
            figures.Add(circle);
            Console.WriteLine("Круг добавлен.");
        }

        static void ViewFiguresList()
        {
            Console.WriteLine("Список фигур:");
            foreach (Figure figure in figures)
            {
                Console.WriteLine($"{figure.Name} ({figure.GetType().Name})");
            }
        }

        static void ViewFigureInfo()
        {
            Console.WriteLine("Введите имя фигуры для просмотра информации:");
            string name = Console.ReadLine();

            Figure figure = figures.Find(f => f.Name == name);
            if (figure != null)
            {
                figure.Print();
            }
            else
            {
                Console.WriteLine("Фигура с таким именем не найдена.");
            }
        }

        static void EditFigure()
        {
            Console.WriteLine("Введите имя фигуры для редактирования:");
            string name = Console.ReadLine();

            Figure figure = figures.Find(f => f.Name == name);
            if (figure != null)
            {
                Console.WriteLine("Введите новое имя:");
                string newName = Console.ReadLine();
                figure.Name = newName;

                Console.WriteLine("Фигура успешно отредактирована.");
            }
            else
            {
                Console.WriteLine("Фигура с таким именем не найдена.");
            }
        }

        static void DeleteFigure()
        {
            Console.WriteLine("Введите имя фигуры для удаления:");
            string name = Console.ReadLine();

            Figure figure = figures.Find(f => f.Name == name);
            if (figure != null)
            {
                figures.Remove(figure);
                Console.WriteLine("Фигура успешно удалена.");
            }
            else
            {
                Console.WriteLine("Фигура с таким именем не найдена.");
            }
        }

        static void CallFigureMethod()
        {
            Console.WriteLine("Введите имя фигуры для вызова метода:");
            string name = Console.ReadLine();

            Figure figure = figures.Find(f => f.Name == name);
            if (figure != null)
            {
                Console.WriteLine("Выберите метод для вызова:");
                Console.WriteLine("1. Вычислить площадь");
                Console.WriteLine("2. Вычислить периметр");

                int choice;
                if (!int.TryParse(Console.ReadLine(), out choice))
                {
                    Console.WriteLine("Некорректный ввод. Повторите попытку.");
                    return;
                }

                switch (choice)
                {
                     case 1:
                        Console.WriteLine($"Площадь фигуры {figure.Name}: {figure.Area()}");
                        break;
                     case 2:
                        Console.WriteLine($"Периметр фигуры {figure.Name}: {figure.Perimeter()}");
                        break;
                     default:
                        Console.WriteLine("Некорректный выбор. Повторите попытку.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Фигура с таким именем не найдена.");
            }
        }
    }
}
