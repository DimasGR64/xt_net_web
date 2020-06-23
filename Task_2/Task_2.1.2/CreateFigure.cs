using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2._1._2
{
    class CreateFigure
    {
        public static void FigureCreate()
        {
            //var str = Console.ReadLine();
            //var type = (FigureType)Enum.Parse(typeof(FigureType), str);
            //Console.WriteLine("input param figure " + type);
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
                            "\n1. Окружность" +
                            "\n2. Круг" +
                            "\n3. Диск");
                        int select;
                        int.TryParse(Console.ReadLine(), out select);
                        if (select == 1)
                        {
                            CreateFigure.RoundCreate();
                            figure = figure ^ FigureType.Round;
                        }
                        else if (select == 2)
                        {
                            CreateFigure.CircleCreate();
                            figure = figure ^ FigureType.Circle;
                        }
                        else if (select == 3)
                        {
                            CreateFigure.DiscCreate();
                            figure = figure ^ FigureType.Disc;
                        }
                        else
                        {
                            CreateFigure.SquareCreate();
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
        public static void RoundCreate()
        {
            Round round = new Round();
            Console.WriteLine("input parametr figure round");
            Console.WriteLine("input coordinate centr: x and y");
            int.TryParse(Console.ReadLine(), out round.X);
            int.TryParse(Console.ReadLine(), out round.Y);
            Console.WriteLine("input radius");
            double.TryParse(Console.ReadLine(), out round.radial);
            Console.WriteLine("figure circle created");
            Console.WriteLine("-------------");
        }
        public static void CircleCreate()
        {
            Circle circle = new Circle();
            Console.WriteLine("input parametr figure circle");
            Console.WriteLine("input coordinate centr: x and y");
            int.TryParse(Console.ReadLine(), out circle.X);
            int.TryParse(Console.ReadLine(), out circle.Y);
            Console.WriteLine("input radius");
            double.TryParse(Console.ReadLine(), out circle.radial);
            Console.WriteLine("figure circle created");
            Console.WriteLine("-------------");
        }

        public static void DiscCreate()
        {
            Disc disc = new Disc();
            Console.WriteLine("input coordinate centr: x and y");
            int.TryParse(Console.ReadLine(), out disc.X);
            int.TryParse(Console.ReadLine(), out disc.Y);
            Console.WriteLine("input radius");
            double.TryParse(Console.ReadLine(), out disc.radial);
            Console.WriteLine("input inside radius");
            double.TryParse(Console.ReadLine(), out disc.radial);
            Console.WriteLine("figure disc created");
            Console.WriteLine("-------------");
        }
        public static void SquareCreate()
        {
            Square square = new Square();
            Console.WriteLine("input side a and side b");
            int.TryParse(Console.ReadLine(), out square.a);
            int.TryParse(Console.ReadLine(), out square.b);
            Console.WriteLine("figure square created");
            Console.WriteLine("-------------");
        }
    }
    [Flags]
    public enum FigureType : byte
    {
        None = 0,
        Round = 1,
        Circle = 2,
        Disc = 3,
        Square = 4
    }
}
