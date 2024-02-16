using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;


namespace _16._02._24
{
    /// <summary>
    /// Абстрактный класс, наследник класса AClass
    /// </summary>
    abstract class BClass:AClass
    {
        /// <summary>
        /// Абстрактный метод для суммирования двух чисел
        /// </summary>
        public abstract int Sum(int x, int y);
    }
}
