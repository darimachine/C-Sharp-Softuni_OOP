using System;
using System.Collections.Generic;
using System.Linq;

namespace Encapsulation_Zad1
{
    class Person : IComparable<Person>
    {
        public string firstName;
        public string lastName;
        public int age;
        public decimal salary;
        public Person(string firstName, string lastName, int age,decimal salary)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
            this.Salary = salary;
        }

        public string FirstName {
            get=>firstName;
            private set 
            {
                if (value.Length < 3)
                {
                    throw new ArgumentException("Name must be at least 3 symbols");
                }
                firstName = value;
            }
        }
        public string LastName {
            get=>lastName;
            private set 
            {
                if (value.Length < 3)
                {
                    throw new ArgumentException("Name must be at least 3 symbols");
                }
                lastName = value;
            }
        }
        public int Age {
            get=>age;
            private set 
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Age must be positive");
                }
                age = value;
            } 
        }
        public decimal Salary {
            get=>salary;
            private set 
            {
                if (value < 650)
                {
                    throw new ArgumentException("Cannot be less than 650");
                }
                salary = value;
            } 
        }
        public void IncreaseSalary(decimal percentage)
        {
            if (this.Age < 30)
            {
                percentage /= 2.0m;
            }
            this.Salary *= 1 + (percentage / 100);
        }
        public int CompareTo(Person other)
        {
            int comparer = other.FirstName.CompareTo(this.FirstName);
            return (comparer == 0) ? this.Age.CompareTo(other.Age) : comparer;
        }

        public override string ToString()
        {
            return $"{this.FirstName} {this.LastName} is {this.Age} yeard old with {this.Salary}";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var people = new List<Person>();
            var person = new Person("Serhan", "Chavdarliev", 35, 1000);
            person.IncreaseSalary(20);
            Console.WriteLine(person);
            Team team = new Team("Team1");
            team.AddPlayer(person);
            Console.WriteLine(team.FirstTeam.Count);
            Console.WriteLine(team.ReserveTeam.Count);

        }
    }
}
