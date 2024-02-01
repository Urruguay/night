using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace MyCommonNamespace
{
    public class Students
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
                if (year < 1900 || year > DateTime.Now.Year)
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
        public Students(string FName, string Gen, int Year)
        {
            this.FName = fName;
            this.Gen = gen;
            this.Year = year;
        }

        public Students(string fullName, char gender, int bYear)
        {
            FName = fName;
            Gen = gen;
            Year = year;
        }

        
    }
}
