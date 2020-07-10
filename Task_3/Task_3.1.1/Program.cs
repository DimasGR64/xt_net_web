using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3._1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            int del;
            int round = 0;

            Console.WriteLine("Input number of people");
            int.TryParse(Console.ReadLine(), out n);
            if (n == 0)
            {
                throw new ArgumentException("please, input number");
            }
            else if (n < 1)
            {
                throw new ArgumentException("Number must be greater than 1");
            }
            List<int> people = new List<int>() { };
            Random rnd = new Random();
            for (int i = 0; i < n; i++)
            {
                int j = rnd.Next(0, 100);
                people.Add(j);
            }
            Console.WriteLine("What people will be cross out");
            int.TryParse(Console.ReadLine(), out del);
            if (del > n)
            {
                throw new ArgumentException("Number must be greater, than number of people");
            }
            while (people.Count >= del)
            {
                for (int i = 0; i < people.Count; i++)
                {
                    if (i % del == 0)
                    {

                        ++round;
                        people.RemoveAt(i);
                        Console.WriteLine("Round {0}. People delete. Number of people: {1}", round, people.Count);
                    }
                    else
                    {
                        people.Add(people[i]);
                        people.RemoveAt(i);

                    }
                }
            }
            Console.WriteLine("Game Over. Impossible cross out more people");
        }
    }
}
