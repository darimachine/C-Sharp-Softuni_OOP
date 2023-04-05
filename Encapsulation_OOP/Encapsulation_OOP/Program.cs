
using ClassLibrary1;
using System;

namespace Encapsulation_OOP
{
    class Manager : Person
    {
        public void FirePerson()
        {
            this.Salary = 23;
        }

    }
    class Person
    {
        public int Age { get => age; set => age = value; }
        private int salary;
        private int age;

        public Person()
        {

        }
        public int Salary
        {
            get { return salary; }
            set
            {
                if (value < 650)
                {
                    this.salary = 650;
                }
                else
                {
                    this.salary = value;
                }
            }
        }
        public void IncreaseSalary()
        {
            this.salary *= 2;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
           
            var person = new Person();
            person.Salary = 300;
            Console.WriteLine(person.Salary);
            person.IncreaseSalary();
            Console.WriteLine(person.Salary);
            Class1 ee = new Class1();



        }
    }
}



