using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Console;


namespace _16._02._24Tasks
{
    /// <summary>
    /// Класс Russian, наследующий функциональность от базового класса Person
    /// </summary>
    class Russian : Person
    {
        /// <summary>
        /// Конструктор без параметров
        /// </summary>
        public Russian() {}
        /// <summary>
        /// Конструктор с параметрами
        /// </summary>
        /// <param name="name"></param>
        public Russian(string name)
        {
            Name = name;
        }
        /// <summary>
        /// Переопределение метода приветствия
        /// </summary>
        public override void Welcome()
        {
            WriteLine($"Приветствую, {Name}!\n");
        }
    }
}
