using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace _26._02._24
{
    /// <summary>
    /// Производный класс для квадрата.
    /// </summary>
    class Square :Figure
    {
        private double side;

        public Square(string name):base(name) { }
        public Square(double side, string name) : base(name)
        {
            this.side = side;
        }
        /// <summary>
        /// Свойство с вещественным типом данных Side
        /// Получает или устанавливает длину стороны квадрата.
        /// </summary>
        public double Side { get => side; set => side = value; }
        public override double Area()
        {
            return side * side;
        }
        public override double Perimeter()
        {
            return 4 * side ;
        }
        public override void Print()
        {
            base.Print();
            WriteLine($"Side1: {side}");
        }
    }
}
