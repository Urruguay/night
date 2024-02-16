using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;


namespace _16._02._24
{
    /// <summary>
    /// Класс, наследующий функциональность от базового класса CClass.
    /// </summary>
    class DerivedClass :CClass
    {

        /*
        /// <summary>
        /// Переопределяет виртуальный метод Metod2 из базового класса.
        /// </summary>
        public override void Metod2()
        {
            base.Metod2();
            WriteLine("Виртуальный метод Metod2 из абстрактного класса AClass,реализованный в классе DerivedClass");
        }
        /// <summary>
        /// Переопределяет абстрактный метод Metod3 из базового класса AClass.
        /// </summary>
        public override void Metod3()
        {
            WriteLine("Metod3 из класса AClass, реализованный в классе DerivedClass");
        }
        /// <summary>
        /// Переопределяет абстрактный метод Metod4 из базового класса AClass.
        /// </summary>
        public override void Metod4()
        {
            WriteLine("Metod4 из класса AClass, реализованный в классе DerivedClass");
        }
        */



        /// <summary>
        /// Переопределенный метод из класса AClass
        /// </summary>
        public override void Metod()
        {
            WriteLine("Метод Metod");
        }
        /// <summary>
        /// Переопределенный метод из класса BClass
        /// </summary>
        public override int Sum(int x, int y)
        {
            return x + y;
        }
        /// <summary>
        /// Переопределенный метод из класса CClass
        /// </summary>
        public override string Hello(string name)
        {
            return  $"Доброго времени суток, {name}!";
        }
        /// <summary>
        /// Выводит приветствие с указанным именем.
        /// </summary>
        /// <param name="name">Имя, которое будет использовано в приветствии.</param>
        public void Conclusion(string name) 
        {
            WriteLine($"Приветсвую, {name}!");
        }
    }
}
