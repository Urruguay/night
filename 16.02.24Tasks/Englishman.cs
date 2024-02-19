using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;


namespace _16._02._24Tasks
{
    /// <summary>
    /// Класс Englishman, наследующий функциональность от базового класса Person
    /// </summary>
    class Englishman : Person
    {
        /// <summary>
        /// Конструктор без параметров
        /// </summary>
        public Englishman() { }
        /// <summary>
        /// Конструктор c параметрами
        /// </summary>
        public Englishman(string name)
        {
            Name = name;
        }

        /// <summary>
        /// Переопределение метода приветствия
        /// </summary>
        public override void Welcome()
        {
            WriteLine($"Hello, {Name}!\n");
        }
    }
}
