using System;

namespace Animal
{
    class Animal 
    {
        public virtual void Eat()
        {
            Console.WriteLine("Eating....");
        }
    }
    class Dog : Animal
    {
        public void Bark()
        {
            Console.WriteLine("Bark Bark");
        }
    }
    class Cat : Animal
    {
        public void Meow()
        {
            Console.WriteLine("Meow");
        }
    }
    class Puppy : Dog
    {
        public void Weep()
        {
            Console.WriteLine("Weep");
        }
        public override void Eat()
        {
            Console.WriteLine("Pupyp Doesnt Eat");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var puppy = new Puppy();
            puppy.Eat();
            puppy.Bark();
            puppy.Weep();
            puppy.Eat();
        }
    }
}
