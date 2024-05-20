using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Console;

namespace _01._03._24
{
    class Teacher : Person
    {
        public string Post { get; set; }
        public int Experience { get; set; }
        public Teacher(string fName, string lName, DateTime date, string faculity, string post, int experience)
        : base(fName, lName, date, faculity)
        {
            this.Post = post;
            this.Experience = experience;
        }
        public override void Info()
        {
            WriteLine($"Teacher: {FName} {LName} ");
            WriteLine($"Birth Date: {Date.ToShortDateString()}");
            WriteLine($"Faculty: {Faculity}");
            WriteLine($"Post: {Post}");
            WriteLine($"Experience: {Experience}");
            WriteLine($"Age: {CalculateAge()}");
            
            WriteLine();
        }
    }
}