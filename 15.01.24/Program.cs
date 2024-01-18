using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace _15._01._24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. Объявить несколько экземпляров класса
            Point pt1 = new Point(); // одиночный экземпляр
            Point pt2 = new Point(2, 3.5);

            // 2. Вывести экземпляры класса
            Write("Object pt1. ");
            pt1.Print();
            Write("Object pt2. ");
            pt2.Print();

            // 3. Вывести статическое поле Point.count
            WriteLine($"Static field Point.count = {Point.count}"); // count = 2

            // 4. Объявить массив экземпляров
            Point[] ptArray = new Point[5]; // создать массив ссылок на Point

            // 5. Вывести статическое поле Point.count еще раз
            WriteLine($"Static field Point.count = {Point.count}"); // count = 2

            // 6. Выделить память для каждого элемента массива типа Point
            for (int i = 0; i < ptArray.Length; i++)
            {
                // при каждом вызове конструктора статическое поле count увеличивается на 1
                ptArray[i] = new Point(i, i * i);
            }

            // 7. Вывести значение Point.count - количество созданных экземпляров класса
            WriteLine($"Static field Point.count = {Point.count}"); // count = 7

            // 8. Демонстрация вызова статического метода LengthPoints()
            WriteLine("Length between pt1 and pt2 is: {0:f3}", Point.LengthPoints(pt1, pt2));

            ReadLine();
        }
    }
}
