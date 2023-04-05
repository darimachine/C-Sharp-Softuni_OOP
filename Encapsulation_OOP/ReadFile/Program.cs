using System;
using System.Collections.Generic;
using System.IO;

namespace ReadFile
{
    class Item : IComparable<Item>
    {
        private string description;
        public int CompareTo(Item other)
        {
            throw new NotImplementedException();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            using StreamReader reader = new StreamReader("txt.txt");
            while (!reader.EndOfStream)
            {
                var number =int.Parse(reader.ReadLine());
                Console.WriteLine(number+1);
            }
        }
    }
}
