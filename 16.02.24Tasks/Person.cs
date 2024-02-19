using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;


namespace _16._02._24Tasks
{
    /// <summary>
    /// Абстрактный класс Person
    /// </summary>
    abstract class Person
    {
        /// <summary>
        /// Автоматическое свойство Name
        /// </summary>
        public string Name {get;set;}
        /// <summary>
        /// Абстрактный метод приветствия Welcome
        /// </summary>
        public abstract void Welcome();
    }
}
