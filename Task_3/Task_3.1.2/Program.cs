using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3._1._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int countRepeat = 0;
            Dictionary<string, int> dicttoinary = new Dictionary<string, int>();
            string text = "Привет друзья, этот текст я выдумал сам. В школе с соченениями у меня было плохо, но я не отчаиваюсь, надеюсь в " +
                "ЭПАМ все будет намного лучше";
            string[] arr = text.ToLower().Split(new string[] { Environment.NewLine, " ", ".", ",", "?", "!", ")", "(", ">", "<", },
                                                  StringSplitOptions.RemoveEmptyEntries);
            int totWords = arr.Length;
            foreach (var item in arr)
            {
                if (dicttoinary.ContainsKey(item))
                {
                    dicttoinary[item]++;
                }
                else
                {
                    dicttoinary.Add(item, 1);
                }
            }
            dicttoinary = dicttoinary.OrderByDescending(e => e.Value).ToDictionary(e => e.Key, e => e.Value);
            Console.WriteLine("слова встречающиеся в тексте в порядке убывания");
            for (int i = 0; i < dicttoinary.Count(); i++)
            {
                Console.WriteLine("{0} {1}", dicttoinary.ElementAt(i).Key, dicttoinary.ElementAt(i).Value);
            }
            for (int i = 0; i < 5; i++)
            {
                countRepeat += dicttoinary.ElementAt(i).Value;
            }
            if (totWords / countRepeat > 0.2)
            {
                Console.WriteLine("Ваш текст не слишком разнообразен, попробуйте использовать больше других слов");
            }
            else
            {
                Console.WriteLine("Поздравляем, Ваш текст разнообразный");
            }
        }
    }
}
