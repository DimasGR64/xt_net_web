using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Task_3._3._3
{
    public static class Pizzeria
    {
        public delegate void PizzaDelegate(int numberInQueue);
        public static event PizzaDelegate PizzaInDoing;
        public static void PizzaInfo(int numberInQueue)
        {
            PizzaSelection Select = PizzaSelection.None;
            Console.WriteLine("Please place an order");
            Console.WriteLine("select:\n\t1: " + PizzaSelection.FourCheeze + "\n\t2: " + PizzaSelection.SaratovPizza +
                "\n\t3: " + PizzaSelection.HomePizza);
            int n = int.Parse(Console.ReadLine());
            if (n == 1)
            {
                Select = PizzaSelection.FourCheeze;
            }
            else if (n == 2)
            {
                Select = PizzaSelection.SaratovPizza;
            }
            else if (n == 3)
            {
                Select = PizzaSelection.HomePizza;
            }
            else
            {
                throw new ArgumentOutOfRangeException("invalid value, please input a number from 1 to 3");
            }
            Console.WriteLine("Make a pizza " + Select);
            Thread.Sleep(1000);
            Console.WriteLine("Buyer " + numberInQueue + ", your pizza " + Select + " ready");
            PizzaInDoing?.Invoke(numberInQueue);
        }
    }
}
