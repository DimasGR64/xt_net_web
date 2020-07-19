using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Task_3._3._3
{
    public class Buyer
    {
        private int numberInQueue;
        public int NumberInQueue
        {
            get
            {
                return numberInQueue;
            }
        }
        public Buyer(int numberInQueue)
        {
            this.numberInQueue = numberInQueue;
        }
        public void MakeAnOrder(int numberInQueue)
        {
            Pizzeria.PizzaInfo(this.numberInQueue);
        }
    }
}
