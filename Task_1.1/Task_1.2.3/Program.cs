using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1._2._3
{
    class Program
    {
        static void Main(string[] args)
        {
            {

            }
            string input = "Антон хорошо начал утро: посушал Стинга, выпил кофе и посмотрел Звездные Войны";
            string[] words = input.Split(new char[] { ' ' }) ;
            int lowerword = 0;
            string word;

            for (int i = 0; i < words.Length; i++)
            {
                word = words[i];
                if (char.IsLower(word[0]))
                {
                    lowerword++;
                }
            }
            Console.WriteLine(lowerword);
        }
    }
}
