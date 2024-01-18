using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace _18._01._24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //// Пример использования класса Point
            //Point point1 = new Point(2.0, 3.0);
            //Point point2 = new Point(-1.0, 4.0);
            //Point point3 = new Point(-2.0, -2.0);

            //point1.GetPoint();
            //point2.GetPoint();
            //point3.GetPoint();

            //Point.DisplayPointStatistics();

            Point[] points = new Point[5];
            for (int i = 0; i < points.Length; i++)
            {
                Write("x = ");
                double x = double.Parse(ReadLine());
                Write("y = ");
                double y = double.Parse(ReadLine());
                points[i] = new Point(x, y);
            }
            
            Point.DisplayPointStatistics();

            ReadLine();
        }
    }
}
