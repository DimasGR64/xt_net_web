using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1._1._6
{
    class Program
    {
        static void Main(string[] args)
        {
            FormatText format = FormatText.None;
            Console.WriteLine("Параметры надписи: {0}", format);
            Console.WriteLine("Введите:\n\t1: bold\n\t2: italic\n\t3: underline\n");
            while (true)
            {
                int n = int.Parse(Console.ReadLine());
                switch (n)
                {
                    case 1: format = format ^ FormatText.Bold;
                        break;
                    case 2: format = format ^ FormatText.Italic;
                        break;
                    case 3: format = format ^ FormatText.Underline;
                        break;
                    default: Console.WriteLine("invalid value, please input a number from 1 to 3");
                        break;
                }
                Console.WriteLine("Параметры надписи: " + format);
                Console.WriteLine("Введите:\n\t1: bold\n\t2: italic\n\t3: underline\n");
            }
        }
    }      
    [Flags]
    enum FormatText : byte
    {
        None = 0,
        Bold = 1,
        Italic = 2,
        Underline = 4,
    }
}
