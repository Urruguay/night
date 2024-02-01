using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ../Students.cs;
using static System.Console;

namespace _15._01._24
{
    internal class Point
    {
        // Тема: Статические методы и данные класса

        // Нестатический класс Point
        class Point
        {
            // 1. Внутренние поля класса Point
            // координаты точки
            private double x;
            private double y;

            // количество экземпляров класса Point - статическое поле
            // если убрать public, то поле будет видимо только в пределах класса
            public static int count;

            // 2. Статический конструктор
            //    - инициализирует только статические поля класса
            //    - не может иметь параметров и модификаторов доступа
            //    - выполняется только один раз
            //    - вызывается средой .NET
            static Point()
            {
                count = 0;
                // x = y = 0; - ошибка, нестатические поля класса нельзя инициализировать в статическом конструкторе
            }

            // 3. Нестатический конструктор - инициализирует нестатические поля класса
            public Point()
            {
                x = y = 1.0;

                // Конструктор вызывается при создании экземпляра класса Point,
                // поэтому нужно увеличить статическое поле на 1
                count++;
            }

            // 4. Еще один нестатический конструктор с двумя параметрами
            public Point(double x, double y)
            {
                this.x = x;
                this.y = y;

                // Конструктор вызывается при создании экземпляра класса Point,
                // поэтому нужно увеличить статическое поле на 1
                Point.count++; // еще один способ доступа к count
            }

            // 5. Методы доступа
            public double GetX() { return x; }
            public double GetY() { return y; }
            public void SetX(double x) { this.x = x; }
            public void Set(double y) { this.y = y; }

            // 6. Метод, который выводит поля класса
            public void Print()
            {
                WriteLine("Fields of instance: ");
                WriteLine("x = {0}, y = {1}", x, y);
            }

            // 7.Статический метод LengthPoints() - вычисляет расстояние между двумя точками типа Point
            public static double LengthPoints(Point p1, Point p2)
            {
                double len;
                len = Math.Sqrt((p1.x - p2.x) * (p1.x - p2.x) + (p1.y - p2.y) * (p1.y - p2.y));
                return len;
            }
        }
    }
}
