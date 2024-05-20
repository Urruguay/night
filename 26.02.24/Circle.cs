using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace _26._02._24
{
    class Circle:Figure
    {
        private double radius;

        public Circle(string name) : base(name) { }
        public Circle(double radius, string name) : base(name)
        {
            this.radius = radius;
        }
        public double Radius { get => radius; set => radius = value; }
        public override double Area()
        {
            return Math.PI * Math.Pow(radius, 2) ;
        }
        public override double Perimeter()
        {
            return 2 * Math.PI * radius;
        }
        public override void Print()
        {
            base.Print();
            WriteLine($"Radius: {radius}");
        }
    }
}
