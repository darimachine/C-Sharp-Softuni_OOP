using System;
using System.Collections.Generic;
using System.Linq;

namespace BoardControl
{
    interface IPerson
    {
        public long Id { get; set; }
    }
    class Citizens : IPerson
    {
        public Citizens(string name, int age, long id)
        {
            Name = name;
            Age = age;
            Id = id;
        }

        public string Name { get; set; }
        public int Age { get; set; }
        public long Id { get; set; }
    }
    class Robots : IPerson
    {
        public Robots(string model, long id)
        {
            Model = model;
            Id = id;
        }

        public string Model { get; set; }
        public long Id { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string line = Console.ReadLine();
            List<IPerson> ids = new List<IPerson>();
            while (line != "End")
            {
                var information = line.Split(" ");
                if (information.Length > 2)
                {
                    string name = information[0];
                    int age = int.Parse(information[1]);
                    long id = long.Parse(information[2]);
                    Citizens citizen = new Citizens(name, age, id);
                    
                    ids.Add(citizen);
                }
                else
                {
                    string model = information[0];
                    
                    long id = long.Parse(information[1]);
                    Robots robot = new Robots(model, id);
                    ids.Add(robot);
                }
                line = Console.ReadLine();
            }
            int number = int.Parse(Console.ReadLine());
            foreach (var id in ids)
            {
                if (IsEndWithNumber(id.Id, number))
                {
                    Console.WriteLine(id.Id);
                }
                
            }
        }
        static bool IsEndWithNumber(long number,int x)
        {
            while (x != 0)
            {
                long last_digit = number % 10;
                long xlast_digit = x % 10;
                if (xlast_digit != last_digit)
                {
                    return false;
                }
                x = x / 10;
                number = number / 10;


            }
            return true;
        }
    }
}
