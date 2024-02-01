using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace _19._01._24
{
    internal class Students
    {
        private string fName;
        private char gen;
        private int year;

        public string FName
        {
            get
            {
                return string.IsNullOrWhiteSpace(fName) ? fName : "Полное имя студента отсутствует или было утеряно.";
               
            }
            set
            {
                fName = value;
            }
        }
        public char Gen
        {
            get
            {
                if (gen != 'M' && gen != 'W')
                {
                    WriteLine("Invalid gender. Use 'M' for men or 'W' for women.");
                }
                return gen;
            }
            set
            {
                gen = value;
            }
        }
        public int Year
        {
            get
            {
                if (year < 1900 || year > 2024/*DateTime.Now.Year*/)
                {
                    WriteLine("Несопоставимая дата рождения студента. Возможно в вашей документации ошибка.");
                }
                return year;
            }
            set
            {
                year = value;
            }
        }
        public Students(string FName, char Gen, int Year)
        {
            this.FName = fName;
            this.Gen = gen;
            this.Year = year;
        }
    }
}
