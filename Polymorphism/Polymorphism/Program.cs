using System;
using System.Collections.Generic;

namespace Polymorphism
{
    interface IAnimal
    {
        void Move();
    }
    public abstract class Mammal
    {
        public abstract void MakeSound();
    }
    public class Person : Mammal, IAnimal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Talkinmg");   
        }

        public void Move()
        {
            Console.WriteLine("Walking"); ;
        }
    }
    public class Cat : Mammal,IAnimal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Meow");
        }

        public void Move()
        {
            Console.WriteLine("Sneaking");      }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Mammal> list = new List<Mammal>();
            list.Add(new Person());
            list.Add(new Cat());
            foreach (var item in list)
            {
                //(item as Cat).MakeSound();
            }
            Console.WriteLine(Mymethod(3453131241));
        }
        static int Mymethod(int a)
        {
            return 1;
        }
        static int Mymethod(long a)
        {
            return 2;
        }
    }
}
