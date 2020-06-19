using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2._1._2
{
    class Program
    {
        static void VelcomePrint()
        {
            Console.WriteLine("Выерите действие:" +
                   "\n1. Добавить фигуру" +
                   "\n2. Вывести фигуры" +
                   "\n3. Очистить холст" +
                   "\n4. Выход");
        }
        static void Main(string[] args)
        {
            int start = 0;
            FigureType figure = FigureType.None;
            do
            {
                Program.VelcomePrint();
                int.TryParse(Console.ReadLine(), out start);
                switch (start)
                {
                    case 1:
                        Console.WriteLine("Выберете тип фигуры:" +
                            "\n1. Круг" +
                            "\n2. Кольцо" +
                            "\n3. Квадрат");
                        int select;
                        int.TryParse(Console.ReadLine(), out select);
                        if (select == 1)
                        {
                            Circle.CircleCreate();
                            figure = figure ^ FigureType.Circle;
                        }
                        else if (select == 2)
                        {
                            Ring.RingCreate();
                            figure = figure ^ FigureType.Ring;
                        }
                        else
                        {
                            Square.SquareCreate();
                            figure = figure ^ FigureType.Square;
                        }
                        break;
                    case 2:
                        Console.WriteLine("Выведены фигуры " + figure);
                        Console.WriteLine("-------------");
                        break;
                    case 3:
                        figure = FigureType.None;
                        Console.WriteLine("-------------");
                        break;
                    default:
                        break;
                }
            } while (start != 4);
        }
    }
    [Flags]
    public enum FigureType : byte
    {
        None = 0,
        Circle = 1,
        Ring = 2,
        Square = 4  
    }
}
