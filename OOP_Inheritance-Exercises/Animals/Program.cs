using System;
using System.Collections.Generic;

namespace Animals
{
    class Animal
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public Animal()
        {

        }
        public Animal(string name, int age,string gender)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
        }
        
        public virtual void ProduceSound()
        {

        }
        
    }
    public class StartUp
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            Animal animal = new Animal();
            List<Animal> animals = new List<Animal>();
            while (command != "Beast!")
            {
                try
                {


                    var lines = Console.ReadLine().Split(" ");

                    if (command == "Cat")
                    {

                        if (lines[2] == "Male")
                        {
                            animal = new TomCat(lines[0], int.Parse(lines[1]));
                        }
                        else
                        {
                            animal = new Kitten(lines[0], int.Parse(lines[1]));
                        }
                    }
                    else if (command == "Dog")
                    {

                        animal = new Dog(lines[0], int.Parse(lines[1]), lines[2]);

                    }
                    else if (command == "Frog")
                    {
                        animal = new Frog(lines[0], int.Parse(lines[1]), lines[2]);
                    }
                    else
                    {
                        Console.WriteLine("Invalid input!");
                        command = Console.ReadLine();
                        continue;
                    }
                    animals.Add(animal);

                    command = Console.ReadLine();
                }
                catch
                {
                    Console.WriteLine("Invalid input!" );
                }
                
                
            }
            foreach (var item in animals)
            {
                if (item.Age > 0)
                {
                    Console.WriteLine(item.GetType().Name);
                    Console.WriteLine($"{item.Name} {item.Age} {item.Gender}");
                    item.ProduceSound();
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                }
                
            }
            
        }
    }
}
