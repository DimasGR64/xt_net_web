using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3._3._1
{
    public static class ArrayExtention
    {
        public static int SummMas(this int[] arr)
        {
            var sum = 0;
            if (arr == null)
            {
                throw new ArgumentNullException("Array can not be null");
            }
            foreach (var item in arr)
                sum += item;
            return sum;
        }
        public static double AverageMass(this int [] arr)
        {
            double sum = 0;
            if (arr == null)
            {
                throw new ArgumentNullException("Array can not be null");
            }
            foreach (var item in arr)
                sum += item;
            return sum / arr.Length;
        }
        public static int MostFrequent(this int[] arr)
        {
            if (arr == null)
            {
                throw new ArgumentNullException("Array can't be null");
            }
            int element = 0;
            int count = 0;
            foreach (var item in arr)
            {
                int res = arr.Where(e => e == item).Count();
                if (res > count)
                {
                    count = res;
                    element = item;
                }
            }return element;
        }
    }
}
