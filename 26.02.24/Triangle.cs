using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26._02._24
{
    class Triangle:Figure
    {
        private int side1;
        private int side2;
        private int side3;

        public Triangle(string name):base(name){ }
        public Triangle(int side1, int side2, int side3, string name) : base(name)
        {
            if (side1 < (side2 + side3) && side2 < (side1 + side3) && side3 < (side1 + side2))
            {
                this.side1 = side1;
                this.side2 = side2;
                this.side3 = side3;
            }
        }
        public int Side1 { get => side1; set => side1 = value; }
        public int Side2 { get => side2; set => side2 = value; }
        public int Side3 { get => side3; set => side3 = value; }

        public override double Area()
        {
            int P = side1 + side2 + side3;
            int p = P / 2;
            return Math.Sqrt(p*(p-side1)*(p-side2)*(p-side3));
        }
        public override double Perimeter()
        {
           return side1 + side2 + side3;
        }
        public override void Print()
        {
            base.Print();
            Console.WriteLine($"{side1}\t{side2}\t{side3}");
        }
    }
}
