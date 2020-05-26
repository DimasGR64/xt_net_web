using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1._2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "Викентий хорошо отметил день рожденья: покушал пиццу, посмотрел кино, пообщался со студентами в чате";
            string[] words = input.Split(new char[] { ' ' });
            float totword = words.Length; 

            int letters = 0;

            for (int i = 0; i < input.Length; i++)
            {
                if (char.IsLetter(input[i]))
                {
                    letters++;
                }
            }
               float aver = letters / totword; // усредненное значение колличества символов без округления

            Console.WriteLine(aver);
        }
    }
}
