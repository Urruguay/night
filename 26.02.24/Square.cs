using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26._02._24
{
    class Square:Figure
    {
        private int side1;

        public Square(string name):base(name) { }
        public Square(int side1, string name) : base(name)
        {
            this.side1 = side1;
        }
        public int Side1 { get => side1; set => side1 = value; }
        public override double Area()
        {
            return side1 * side1;
        }
        public override double Perimeter()
        {
            return Math.Pow(side1, 2) * 2 ;
        }
        public override void Print()
        {
            base.Print();
            Console.WriteLine($"{side1}");
        }
    }
}
