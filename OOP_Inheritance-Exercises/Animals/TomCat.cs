using System;

namespace Animals
{
    class TomCat : Cat
    {
        public TomCat(string name, int age) : base(name, age, "Male")
        {
        }

        public override void ProduceSound()
        {
            Console.WriteLine("MEOW");
        }
    }
}
