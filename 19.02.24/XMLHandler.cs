using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Console;


namespace _19._02._24
{
    class XMLHandler : AbstractHandler
    {
        public override void Open()
        {
            WriteLine("Open document format - XML");
        }
        public override void Create()
        {
            WriteLine("Creat document format - XML");
        }
        public override void Change()
        {
            WriteLine("Change document format - XML");
        }
        public override void Save()
        {
            WriteLine("Save document format - XML");
        }
    }
}
