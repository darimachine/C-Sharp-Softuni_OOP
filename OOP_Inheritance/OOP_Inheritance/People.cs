using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Inheritance
{
    class Person
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public Person(string name,string address)
        {
            this.Name = name;
            this.Address = address;
        }

        
    }
    class Employee : Person
    {
        

        public string Company { get; set; }
        public Employee(string name, string address,string company) : base(name,address)
        {
            this.Company = company;
        }
        public virtual void Add()
        {
            Console.WriteLine();
        }
    }
    class Student : Person
    {
        
        public string School { get; set; }
        public Student(string name,string adress):base(name,adress)
        {
            
        }
        
        public override void Add()
        {
            base.Add;
            base.Name = "serhan";
        }
    }
    class UniversetyStudent : Student
    {
        public int Course { get; set; }
        
    }
}
