using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace _13._02._24
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee[] emp = new Employee[5];
            emp[0] = new Employee();
            emp[1] = new Employee("Дарья","Овчарук", new DateTime(2004, 4, 27), 4500);
            emp[2] = new Employee("Артем", "Ботнарь", new DateTime(2006, 6, 15), 3500);
            emp[3] = new Employee("Максим", "Родичев", new DateTime(2006, 12, 6), 4500);
            emp[4] = new Employee("Никита", "Лунгу", new DateTime(2007, 1, 7), 3500);

            for(int i = 0; i < emp.Length; i++)
            {
                if (emp[i] != null)
                {
                    emp[i].Info();
                    WriteLine($"Salary with coefficient 1.1: {emp[i].Calc(1.1)}\n");
                }
            }
            Read();
        }
    }
}
