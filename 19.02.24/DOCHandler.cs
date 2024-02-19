using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace _19._02._24
{
    class DOCHandler : AbstractHandler
    {
        public override void Open()
        {
            WriteLine("Open document format - DOC");
        }
        public override void Create()
        {
            WriteLine("Creat document format - DOC");
        }
        public override void Change()
        {
            WriteLine("Change document format - DOC");
        }
        public override void Save()
        {
            WriteLine("Save document format - DOC");
        }
    }
}
