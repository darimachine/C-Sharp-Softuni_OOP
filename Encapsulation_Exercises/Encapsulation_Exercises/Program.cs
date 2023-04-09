using System;
using System.Collections.Generic;
using System.Linq;

namespace Encapsulation_Exercises
{
    class Pizza
    {
        private string name;
        public string Name 
        {
            get => name;
            private set 
            {
                if (value == "" || value == null || value.Length > 15 || value.Length<1)
                {
                    throw new ArgumentException("Pizza name should be between 1 and 15 symbols");
                }
                ; } 
        }
        private Dough dough;
        private List<Topping> toppings;

        public IReadOnlyCollection<Topping> Toppings=>this.toppings;
        public Dough Dough 
        { 
            get; 
            private set; 
        }
        
        
        public void Add(Topping element)
        {
            if (this.toppings.Count >= 10)
            {
                throw new ArgumentOutOfRangeException("Number of toppings should be in range [0..10].");
            }
            this.toppings.Add(element);
        }
        public Pizza(string name, Dough dough)
        {
            this.toppings = new List<Topping>();
            this.Name = name;
            this.Dough = dough;
        }
        public double CalculateCalories()
        {
            double result = this.Dough.Calories + toppings.Sum(x => x.Calories);
            return result;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var pizzaName = Console.ReadLine().Split(" ");
                var dought = Console.ReadLine().Split(" ");
                string flourtype = dought[1];
                string bakingtechnique = dought[2];
                int weight = int.Parse(dought[3]);
                Dough dough = new Dough(flourtype, bakingtechnique, weight);
                Pizza pizza = new Pizza(pizzaName[1], dough);

                var command = Console.ReadLine();
                while (command != "END")
                {
                    var line = command.Split(" ");
                    string type = line[1];
                    int toppingWeight = int.Parse(line[2]);
                    Topping topping = new Topping(type, toppingWeight);
                    pizza.Add(topping);
                    command = Console.ReadLine();
                }
                Console.WriteLine($"{pizzaName[1]} - {pizza.CalculateCalories():f2} Calories.");
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
           
        }
    }
}
