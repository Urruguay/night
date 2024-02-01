using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace _18._01._24
{
    internal class Point
    {
        /// <summary>
        /// Поля с координатами точек
        /// </summary>
        public double x;
        public double y;

        /// <summary>
        /// Cтатические поля, опредеяющие количество точек 
        /// 1-й, 2-й, 3-й, 4-й координатной четверти, а также общее количество точек
        /// </summary>
        private static int quarter1;
        private static int quarter2;
        private static int quarter3;
        private static int quarter4;
        private static int totalCount;

        /// <summary>
        /// Конструктор с параметрами, принимающий координаты точки
        /// </summary>
        public Point(double x, double y)
        {
            this.x = x;
            this.y = y;

            //// Определение четверти и обновление счетчиков
            UpdateQuarterCount();
            totalCount++;
        }

        /// <summary>
        /// Метод для вывода координат точки
        /// </summary>
        public void GetPoint()
        {
            WriteLine($"Coordinates: ({x}, {y})");
        }

        /// <summary>
        /// Статический метод, выводящий количество точек, 
        /// расположенных в каждой координатной четверти, и общее количество точек
        /// </summary>
        public static void DisplayPointStatistics()
        {
            WriteLine($"Number of points in Quarter 1: {quarter1}");
            WriteLine($"Number of points in Quarter 2: {quarter2}");
            WriteLine($"Number of points in Quarter 3: {quarter3}");
            WriteLine($"Number of points in Quarter 4: {quarter4}");
            WriteLine($"Total number of points: {totalCount}");
        }

        /// <summary>
        /// Приватный метод для определения четверти и обновления счетчиков
        /// </summary>
        private void UpdateQuarterCount()
        {
            if (x > 0 && y > 0)
            {
                quarter1++;
            }
            else if (x < 0 && y > 0)
            {
                quarter2++;
            }
            else if (x < 0 && y < 0)
            {
                quarter3++;
            }
            else if (x > 0 && y < 0)
            {
                quarter4++;
            }
            else
            {
                WriteLine("zero point");
            }
        }
    }
}
