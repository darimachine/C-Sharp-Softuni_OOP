using System;
using System.Collections.Generic;

namespace List_Inheritance
{
    class RandomStringList<T> : List<T>
    {
        private Random random;
        public RandomStringList()
        {
            random = new Random();
        }
        public T GetRandomElement()
        {
            var index = random.Next(0, base.Count);
            return base[index];
        }
        public void RemoveRandomElement()
        {
            var index = random.Next(0, base.Count);
            base.RemoveAt(index);
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            var list = new RandomStringList<int>();
            list.Add(5);
            list.Add(2);
            list.Add(3);
            list.Add(1);
            Console.WriteLine(list.GetRandomElement());
            Console.WriteLine(string.Join(" ",list));
        }
    }
}
