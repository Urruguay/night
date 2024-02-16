using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16._02._24
{
    /// <summary>
    /// абстрактный класс, наследник класса BClass
    /// </summary>
    abstract class CClass:BClass
    {
        /// <summary>
        /// абстрактный метод для вывода приветствия
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public abstract string Privetstvie(string s);
    }
}
