using System;

namespace Restourant
{
    class Product
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public Product()
        {

        }
        public Product(string name, decimal price)
        {
            this.Name = name;
            this.Price = price;
        }
    }
    class Beverage : Product
    {
        public double Milliliters { get; set; }
        public Beverage(string name, decimal price,double milliliters) : base(name, price)
        {
            this.Milliliters = milliliters;
        }
    }
    class HotBeverage : Beverage
    {
        public HotBeverage(string name, decimal price, double milliliters) : base(name, price, milliliters)
        {
        }
    }
    class Coffee : HotBeverage
    {
        public Coffee(string name, decimal price, double milliliters,double caffeine) : base(name, price, milliliters)
        {
            base.Milliliters = 50;
            base.Price = 3.50m;
            this.Caffeine = caffeine;
        }

        public double CoffeeMilliliters { get; set; } = 50;
        public decimal CoffeePrice { get; set; } = 3.50m;
        public double Caffeine { get; set; }
       
    }
    class Tea : HotBeverage
    {
        public Tea(string name, decimal price, double milliliters) : base(name, price, milliliters)
        {
        }
    }

    class ColdBeverage : Beverage
    {
        public ColdBeverage(string name, decimal price, double milliliters) : base(name, price, milliliters)
        {
        }
    }

    class Food : Product
    {
        public double Grams { get; set; }
        public Food(string name, decimal price,double grams) : base(name, price)
        {
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
