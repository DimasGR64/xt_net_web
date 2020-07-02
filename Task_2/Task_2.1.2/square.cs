using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2._1._2
{
    public class Square : AbstractFigure
    {
        public int side;
        public Square(int x, int y, int side) : base(x, y)
        {
        }
        public int GetArea(int side) => this.side * this.side;
    }
}
