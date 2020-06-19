using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2._1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            string first = "Hello ";
            string second = "World";
            char symb = 'h';
        }
    }
    class OperationOnString
    {
        public static void Comparison(string str1, string str2) // comparison method
        {
            int value = String.CompareOrdinal(str1, str2);
            if (value == 0)
            {
                Console.WriteLine("string equal");
            }
            else
            {
                Console.WriteLine("string not equal");
            }
        }
        public static string Concat(string str1, string str2) // method of join two string
        {
            return str1 + str2;
        }
        public static void FoundSimbol(string str, char symb) // found symbol method
        {
            if (str.Contains(symb))
            {
                Console.WriteLine("character is contained in string");
            }
            else
            {
                Console.WriteLine("character not contained in string");
            }
        }
        public static char[] StringToChar(string str) // method to convert a string to an array of characters
        {
            char[] symb;
            return symb = str.ToCharArray(); ;
        }
        public static string CharTostring(char[] symb) // method to convert array characters to string
        {
            string str = ("");
            for (int i = 0; i < symb.Length; i++)
            {
                string buffer = symb[i].ToString();
                str = str + buffer;
            }
            return str;
        }
    }
}
