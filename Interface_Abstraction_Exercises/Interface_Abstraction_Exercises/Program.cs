using System;

namespace Interface_Abstraction_Exercises
{
    interface IPerson
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
    interface IIdentifiable
    {
        public string Id { get; set; }
    }
    interface IBirthable
    {
        public string Birthdate { get; set; }
    }
    class Citizen : IPerson,IIdentifiable,IBirthable
    {
        public Citizen(string name, int age,string id, string birthdate)
        {
            Name = name;
            Age = age;
            this.Id = id;
            this.Birthdate = birthdate;
        }

        public string Name { get; set; }
        public int Age { get; set; }
        public string Id { get; set; }
        public string Birthdate { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            string id = Console.ReadLine();
            string birthdate = Console.ReadLine();
            IIdentifiable identifiable = new Citizen(name, age, id, birthdate);
            IBirthable birthable = new Citizen(name, age, id, birthdate);
            Console.WriteLine(identifiable.Id);
            Console.WriteLine(birthable.Birthdate);


        }
    }
}
