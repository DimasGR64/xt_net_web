using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3._2
{
    public class DynamicArray<T> : IEnumerable<T>
    {
        private T[] arr;
        public DynamicArray() //1
        {
            arr = new T[8];
        }
        public DynamicArray(int capacity) //2
        {
            arr = new T[capacity];
        }
        public DynamicArray(IEnumerable<T> collection) //3
        {
            arr = collection.ToArray();
        }

        public void Add(T item) //4 with question
        {
            if (length < capacity)
            {
                arr[length] = item;
                length++;
            }
            else
            {
                capacity = capacity * 2;
                T[] newArray = new T[capacity];
                for (int i = 0; i < arr.Length; i++)
                    newArray[i] = arr[i];
                newArray[length] = item;
                length++;
                arr = newArray;
            }
        }

        public T[] AddRange(IEnumerable<T> collection) // 5
        {
            int countCollection = 0;
            int i = 0;
            foreach (var item in collection)
            {
                ++countCollection;
            }
            arr = new T[countCollection];
            foreach (var item in collection)
            {
                arr[i++] = item;
                length = arr.Length;
            }
            return arr;
        }

        public bool Remove(T element) // 6
        {
            for (int i = 0; i < Length; i++)
            {
                if (arr[i].Equals(element))
                {
                    for (int j = i + 1; j < Length; j++)
                        arr[i] = arr[j];
                    length--;
                    return true;
                }
            }
            return false;
        }
        private int length; //7
        public int Length
        {
            get
            {
                return length;
            }
        }
        private int capacity; //8
        public int Capacity
        {
            get
            {
                return capacity;
            }
        }
        public bool Insert(T element, int position) // 7
        {
            if (position >= Length)
            {
                throw new ArgumentOutOfRangeException("position must be lower than Lenght");
            }
            else if (Capacity > Length)
            {
                Add(element);
                return true;
            }
            if (Capacity == Length)
            {
                capacity *= 2;
                for (int i = 0; i < Length; i++)
                {
                    if (i == position)
                    {
                        Add(element);
                        for (int j = i + 1; j < Length; j++)
                        {
                            arr[i] = arr[j];
                        }
                    }
                }
                return true;
            }
            return true;
        }

        public T this[int index]
        {
            get
            {
                if (index < 0 || index >= capacity)
                    throw new ArgumentOutOfRangeException();
                return arr[index];
            }
            set
            {
                if (index < 0 || index >= capacity)
                    throw new ArgumentOutOfRangeException();
                arr[index] = value;
            }
        }
        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < length; i++)
                yield return arr[i];
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return arr.GetEnumerator();
        }
    }
}