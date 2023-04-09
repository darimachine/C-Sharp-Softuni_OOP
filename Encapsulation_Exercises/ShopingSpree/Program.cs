using System;
using System.Collections.Generic;
using System.Linq;

namespace ShopingSpree
{
    class Person
    {
        private string name;
        public string Name 
        { 
            get=>name;
            private set 
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Name cannot be empty");
                }
                name = value;
            } 
        }
        private int money;
        public int Money 
        { 
            get=>money;
            set 
            { 
                money = value;
            }
        }
        public Person(string name, int money)
        {
            if (money < 0)
            {
                throw new Exception("Money cannot be negative");
            }
            this.BagOfProducts = new List<Product>();
            this.Name = name;
            this.Money = money;
        }
        public List<Product> BagOfProducts { get; set; }
    }
    class Product
    {
        public Product(string name, int cost)
        {
            Name = name;
            Cost = cost;
        }

        private string name;
        public string Name
        {
            get => name;
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Name cannot be empty");
                }
                name = value;
            }
        }
        private int cost;
        public int Cost 
        { 
            get=>cost;
            private set 
            {
                if (value < 0)
                {
                    throw new ArgumentException("Money cannot be negative");
                }
                cost = value;
            }
        } 
    }
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var persons = Console.ReadLine().Split(";", StringSplitOptions.RemoveEmptyEntries);
                var products = Console.ReadLine().Split(";", StringSplitOptions.RemoveEmptyEntries);
                List<Person> personsList = new List<Person>();
                List<Product> productList = new List<Product>();
                foreach (var person in persons)
                {
                    var personDetail = person.Split("=");
                    var name = personDetail[0];
                    var money = int.Parse(personDetail[1]);
                    Person people = new Person(name, money);
                    personsList.Add(people);
                }
                foreach (var product in products)
                {
                    var productDetail = product.Split("=");
                    var name = productDetail[0];
                    var cost = int.Parse(productDetail[1]);
                    Product producte = new Product(name, cost);
                    productList.Add(producte);
                }
                string command = Console.ReadLine();
                while (command != "END")
                {
                    var shopping = command.Split(" ");
                    var personName = shopping[0];
                    var productName = shopping[1];
                    Person currentPerson = personsList.FirstOrDefault(x => x.Name == personName);
                    Product currentProduct = productList.FirstOrDefault(x => x.Name == productName);
                    if (currentPerson.Money >= currentProduct.Cost)
                    {
                        currentPerson.Money -= currentProduct.Cost;
                        currentPerson.BagOfProducts.Add(currentProduct);
                        Console.WriteLine($"{currentPerson.Name} bought {currentProduct.Name}");
                    }
                    else
                    {
                        Console.WriteLine($"{currentPerson.Name} can't afford {currentProduct.Name}");
                    }
                    command = Console.ReadLine();
                }
                foreach (var person in personsList)
                {
                    if (person.BagOfProducts.Count == 0)
                    {
                        Console.Write($"{person.Name} - Nothing bought");
                        continue;
                    }
                    Console.WriteLine($"{person.Name} - {string.Join(", ", person.BagOfProducts.Select(x => x.Name))}");

                }
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
        }
    }

}
    
