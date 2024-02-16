using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16._02._24
{
    class DerivedClass:CClass
    {
        //public override void Metod2()
        //{
        //    base.Metod2();
        //     Console.WriteLine("Виртуальный метод Metod2 из абстрактного класса AClass,реализованный в классе DerivedClass");
        //}
        //public override void Metod3()
        //{
        //    Console.WriteLine("Metod3 из класса AClass, реализованный в классе DerivedClass");
        //}
        //public override void Metod4()
        //{
        //    Console.WriteLine("Metod4 из класса AClass, реализованный в классе DerivedClass");
        //}
        
        /// <summary>
        /// переопределенный метод из класса AClass
        /// </summary>
        public override void Metod()
        {
            Console.WriteLine("Метод Metod");
        }
        public override int Metod2(int x, int y)
        {
            return x + y;
        }
        public override string Privetstvie(string s)
        {
            return  $"Приветствую тебя,{s}";
        }
        public void Vyvod(string s) 
        {
            Console.WriteLine($"Привет,{s}");
        }
    }
}
