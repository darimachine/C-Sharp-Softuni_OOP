using System;

namespace Animals
{
    class Animal
    {
        public string Name { get; set; }
        public string FavouriteFood { get; set; }
        public virtual string ExplainSelf()
        {
            return "ANIMALLLLLLLLLLLLL";
        }
    }
    class Cat : Animal
    {
        public override string ExplainSelf()
        {
            return "Meowwww";
        }
    }
    class Dog : Animal
    {
        public override string ExplainSelf()
        {
            return "Woof Woof";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            recFunc(12);
        }
        public static void recFunc(int n)
        {
            if (n == 0)
            {
                return;
            }
            recFunc(n / 2);
            Console.Write(n % 2);
        }
    }
  
    
}
