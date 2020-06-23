using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2._1._2
{
    class Program
    {
        static void Main(string[] args)
        {
            CreateFigure.FigureCreate();
        }
        public static void VelcomePrint()
        {
            Console.WriteLine("Выерите действие:" +
                   "\n1. Добавить фигуру" +
                   "\n2. Вывести фигуры" +
                   "\n3. Очистить холст" +
                   "\n4. Выход");
        }
    }
}