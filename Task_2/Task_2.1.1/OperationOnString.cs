using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2._1._1
{
    public class OperationOnString
    {
        public void Comparison(string str1, string str2)
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
        public static string Concat(string str1, string str2)
        {
            return str1 + str2;
        }
        public bool FoundSimbol(char[] arrsymb, char symb)
        {
            if (arrsymb.Contains(symb))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static char[] StringToChar(string str)
        {
            char[] symb;
            return symb = str.ToCharArray(); ;
        }
        public static string CharTostring(char[] symb)
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
