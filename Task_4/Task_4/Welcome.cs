using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task_4
{
    public static class Welcome
    {
        public static string ControlFolder = @"D:\EPAM\From_Task_4.1";
        public static string TemplFolder = @"D:\EPAM\Recover";
        public static void Interactive()
        {
            int n;
            Console.WriteLine("Which mode do you want use?:"
                + "\n1. Watching"
                + "\n2. Rollback");
            int.TryParse(Console.ReadLine(), out n);
            if (n < 1 && n > 2)
            {
                throw new ArgumentException("Please input 1 or 2");
            }
            else if (n == 1)
            {
                Watching.Watch();
            }
            else
            {
                FileMaker.Recovery(ControlFolder);
            }
        }
    }
}
