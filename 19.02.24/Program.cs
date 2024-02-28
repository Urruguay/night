using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace _19._02._24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Введите формат документа (XML, TXT, DOC):");
            string format = ReadLine();

            AbstractHandler handler = null;

            switch (format.ToUpper())
            {
                case "XML":
                    handler = new XMLHandler();
                    break;
                case "TXT":
                    handler = new TXTHandler();
                    break;
                case "DOC":
                    handler = new DOCHandler();
                    break;
                default:
                    WriteLine("Неподдерживаемый формат документа.");
                    return;
            }

            handler.Open();
            handler.Create();
            handler.Change();
            handler.Save();

            Read();
        }
    }
}
