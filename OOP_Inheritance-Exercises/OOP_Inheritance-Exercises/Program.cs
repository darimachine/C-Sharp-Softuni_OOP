using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Inheritance_Exercises
{
    class Person
    {
        public string Name { get; set; }
        private int age;
        public int Age {
            get { return age; }
            set { age = value; } }
        public Person(string name, int age)
        {
            this.Age = age;
            this.Name = name;
        }
        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append(String.Format("Name: {0}, Age: {1}",
                                 this.Name,
                                 this.Age));

            return stringBuilder.ToString();
        }

    }
    class Child : Person
    {
        public Child(string name,int age ):base(name, age)
        {
            if (age > 15)
            {
                throw new ArgumentException();
            }
            else
            {
                this.Age = age;
            }
        }
    }
    class Program
    {
        
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            Person person;
            if (age < 0)
            {
                return;
            }
            else if (age <= 15)
            {
                person = new Child(name, age);
            }
            else{
                person = new Person(name, age);
            }
            
            Console.WriteLine(person);
            

        }
    }
}
