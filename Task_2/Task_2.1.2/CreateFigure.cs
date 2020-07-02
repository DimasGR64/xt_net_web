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
            int start = 0;
            WelcomePrint print = new WelcomePrint();
            List<AbstractFigure> figureCollections = new List<AbstractFigure> { };
            do
            {
                print.VelcomePrint();
                int.TryParse(Console.ReadLine(), out start);
                switch (start)
                {
                    case 1:
                        AbstractFigure figure = SelectFigure();
                        AddFigure(figure, figureCollections);
                        break;
                    case 2:
                        ShowFigure(figureCollections);
                        break;
                    case 3:
                        
                        break;
                    default:
                        break;
                }
            } while (start != 4);
        }
        public static AbstractFigure SelectFigure()
        {
            Console.WriteLine("Выберете тип фигуры:" +
                "\n1. Окружность" +
                "\n2. Круг" +
                "\n3. Диск" +
                "\n4. Квадрат" +
                "\n5. Линия");
            int select;
            int.TryParse(Console.ReadLine(), out select);
            if (select == 1)
            {
                return RoundCreate();
            }
            else if (select == 2)
            {

                return CircleCreate();
            }
            else if (select == 3)
            {
                return DiscCreate();
            }
            else if (select == 4)
            {
                return SquareCreate();
            }
            else
            {
                return LineCreate();
            }
        }
        public static void AddFigure(AbstractFigure figure, List<AbstractFigure> list)
        {
            list.Add(figure);
        }

        public static void ShowFigure(List<AbstractFigure> list)
        {
            for (int i = 0; i < list.ToArray().Length; i++)
            {
                Console.WriteLine(list[i]);
            }
        }
        public static AbstractFigure RoundCreate()
        {
            Console.WriteLine("input coordinate point a X1 and Y1");
            int x1 = int.Parse(Console.ReadLine());
            int y1 = int.Parse(Console.ReadLine());
            Console.WriteLine("input radius");
            int radial = int.Parse(Console.ReadLine());
            Console.WriteLine("figure circle created");
            Console.WriteLine("-------------");
            return new Round(x1, y1, radial);
        }
        public static AbstractFigure CircleCreate()
        {
            Console.WriteLine("input coordinate point a X1 and Y1");
            int x1 = int.Parse(Console.ReadLine());
            int y1 = int.Parse(Console.ReadLine());
            Console.WriteLine("input radius");
            int radial = int.Parse(Console.ReadLine());
            Console.WriteLine("figure circle created");
            Console.WriteLine("-------------");
            return new Circle(x1, y1, radial);
        }

        public static AbstractFigure DiscCreate()                       
        {
            Console.WriteLine("input coordinate point a X1 and Y1");
            int x1 = int.Parse(Console.ReadLine());
            int y1 = int.Parse(Console.ReadLine());
            Console.WriteLine("input radius");
            int radial = int.Parse(Console.ReadLine());
            Console.WriteLine("input inside radius");
            int Insideradial = int.Parse(Console.ReadLine());
            Console.WriteLine("figure disc created");
            Console.WriteLine("-------------");
            return new Disc(x1, y1, radial, Insideradial);
        }
        public static AbstractFigure SquareCreate()
        {
            Console.WriteLine("input coordinate point a X1 and Y1");
            int x1 = int.Parse(Console.ReadLine());
            int y1 = int.Parse(Console.ReadLine());
            Console.WriteLine("input side");
            int side = int.Parse(Console.ReadLine());
            Console.WriteLine("figure square created");
            Console.WriteLine("-------------");
            return new Square(x1, y1, side);
        }
        public static AbstractFigure LineCreate()
        {
            Console.WriteLine("input coordinate point a X1 and Y1");
            int x1 = int.Parse(Console.ReadLine());
            int y1 = int.Parse(Console.ReadLine());
            Console.WriteLine("input coordinate point b X2 and Y2");
            int x2 = int.Parse(Console.ReadLine());
            int y2 = int.Parse(Console.ReadLine());
            Console.WriteLine("figure line created");
            Console.WriteLine("-------------");
            return new Line(x1, y1, x2, y2);
        }
    }
}
