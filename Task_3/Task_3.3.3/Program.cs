using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3._3._3
{
    public class Program
    {
        static void Main(string[] args)
        {
            Buyer buyer = new Buyer(1);
            buyer.MakeAnOrder(2);
            Console.ReadKey();
        }
    }
}