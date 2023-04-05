using System;
using System.Collections.Generic;

namespace Immutable
{
    class Person
    {
        public Person(params string[] persons)
        {
            this.People = new List<string>( persons );
            
        }
        public IReadOnlyList<string> People { get; private set; }
       
    }
    class Program
    {
        static void Main(string[] args)
        {
            var persons = new Person("serhan", "birol", "mishka");
            persons.People.Clear();
            Console.WriteLine(persons.People.Count);
        }
    }
}
