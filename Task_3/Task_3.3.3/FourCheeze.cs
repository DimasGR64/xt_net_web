using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3._3._3
{
    public class FourCheeze : AbstractPizza
    {
        public FourCheeze(int size, int price)
        {
            this.Size = size;
            this.Price = price;
            this.Name = "fourCheeze";
        }
    }
}
