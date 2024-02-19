using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace _16._02._24Tasks
{
    class Program
    {
        static void Main(string[] args)
        {
            // Создание экземпляров разных классов
            Moldovan moldovan = new Moldovan("Ваня");
            Russian russian = new Russian("Иван");
            Englishman englishman = new Englishman("Ivan");

            // Вызов метода приветствия для каждого экземпляра
            moldovan.Welcome();
            russian.Welcome();
            englishman.Welcome();

            Read();
        }
    }
}
