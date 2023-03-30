using System;
using System.Collections.Generic;
using System.Linq;

namespace Random_Zad
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> array = Console.ReadLine().Split(" ").ToList();
            Console.WriteLine(string.Join(";",array));
            array = array.Where(x=>x.EndsWith('а')).ToList();
            foreach (var item in array)
            {
                Console.WriteLine(item);
            }
        }
    }
}
