using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace _16._02._24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //DerivedClass derivedClass = new DerivedClass();
            //derivedClass.Metod4();
            //derivedClass.Metod3();
            //derivedClass.Metod2();
            //derivedClass.Metod1();
            //ReadLine();
            //AClass class1=new DerivedClass();
            //class1.Metod1();
            //class1.Metod2();
            //class1.Metod3();
            //class1.Metod4();
            //ReadLine();

            DerivedClass der1= new DerivedClass();
            der1.Metod();
            WriteLine(der1.Sum(54,15));
            WriteLine(der1.Hello("Ирина"));
            der1.Conclusion("Виктор");
            Read();
        }
    }
}
