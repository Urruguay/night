using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16._02._24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //DerivedClass derivedClass = new DerivedClass();
            //derivedClass.Metod3();
            //derivedClass.Metod4();
            //derivedClass.Metod2();
            //derivedClass.Metod1();
            //Console.ReadLine();
            //AClass class1=new DerivedClass();
            //class1.Metod1();
            //class1.Metod2();
            //class1.Metod3();
            //class1.Metod4();
            //Console.ReadLine();

            DerivedClass der1= new DerivedClass();
            der1.Metod();
            Console.WriteLine(der1.Metod2(5,10));
            Console.WriteLine(der1.Privetstvie("Тор,сын Одина"));
            der1.Vyvod("Андрей");
            Console.ReadLine();
        }
    }
}
