using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace _26._02._24
{
    /// <summary>
    /// Абстрактный метод Figure
    /// </summary>
    abstract class Figure
    {
        private string name;

        public Figure(string name)
        {
            this.name = name;
        }
        /// <summary>
        /// Свойство с вещественным типом данных Side
        /// Получает или устанавливает длину стороны квадрата.
        /// </summary>
        public string Name { get => name; set => name = value; }
        public abstract double Area();
        public abstract double Perimeter();
        public virtual void Print() 
        {
            WriteLine($"Название фигуры: {name}");
        }
    }
}
