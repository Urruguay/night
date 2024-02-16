using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;


namespace _16._02._24
{
    /// <summary>
    /// Абстрактный класс, наследник класса BClass
    /// </summary>
    abstract class CClass:BClass
    {
        /// <summary>
        /// Абстрактный метод для вывода приветствия
        /// </summary>
        public abstract string Hello(string name);
    }
}
