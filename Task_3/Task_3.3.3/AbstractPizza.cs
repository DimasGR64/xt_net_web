using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3._3._3
{
    public abstract class AbstractPizza
    {
        private int size;
        private int price;
        private string name;
        public int Size 
        { get
            {
                return size;
            }
            set
            {
                if (size == 24)
                {
                    size = value;
                }
                if (size == 36)
                {
                    size = 2 * value;
                }
            }
        }
        public int Price 
        { get
            {
                return price;
            }
            set
            {
                if (size == 24)
                {
                    price = value;
                }
                if (size == 36)
                {
                    price = 2 * value;
                }
            }
        }
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
    }
}
