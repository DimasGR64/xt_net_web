using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1._2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "написать программу которая";
            string str = "описание";
            string buffer;
            StringBuilder output = new StringBuilder("") ;
            
            for (int i = 0; i < input.Length; i++)
            {
                buffer = input[i].ToString();
                if (str.Contains(buffer))
                {
                    output.AppendFormat(buffer);
                    output.AppendFormat(buffer);
                }
                else
                {
                    output.AppendFormat(buffer);
                }
            } 
            Console.WriteLine(output);          
        }
      

    }
}
