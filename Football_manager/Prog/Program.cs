﻿using EPAM.FoolballManager.Coach.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog
{
    class Program
    {
        public static CoachManager BLL => new CoachManager();
        static void Main(string[] args)
        {
            BLL.DeletePlayer(18);
            Console.WriteLine("123");
            //foreach (var item in BLL.GetAllPlayers())
            //{
            //    Console.WriteLine(item);
            //}
        }
    }
}
