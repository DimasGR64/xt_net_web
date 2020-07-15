using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Task_3_3_2
{
    public static class StringExtentios
    {
        public static void SuperStringExtention(this string str)
        {
            if (Regex.IsMatch(str, "[a-zA-z]") && Regex.IsMatch(str, "[а-яёА-ЯЁ]") ||
                Regex.IsMatch(str, "[a-zA-z]") && Regex.IsMatch(str, "[0-9]") ||
                Regex.IsMatch(str, "[а-яёА-ЯЁ]") && Regex.IsMatch(str, "[0-9]"))
            {
                Console.WriteLine("Mixed");
            }
            else if (Regex.IsMatch(str, "[а-яёА-ЯЁ]"))
            {
                Console.WriteLine("Russian");
            }
            else if (Regex.IsMatch(str, "[a-zA-z]"))
            {
                Console.WriteLine("English");
            }
            else if(Regex.IsMatch(str, "[0-9]"))
            {
                Console.WriteLine("Numbers");
            }
            else
            {
                Console.WriteLine("Unknown language");
            }
        }
    }
}