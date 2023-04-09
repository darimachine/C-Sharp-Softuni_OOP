using System;
using System.Collections.Generic;

namespace Encapsulation_Exercises
{
    class Topping
    {
        //private const string TypeException = $"Cannot place {this.Type} on top of your pizza";
        private Dictionary<string, double> toppingTypeDict = new Dictionary<string, double>()
        {
            {"meat",1.2 },
            {"meggies",0.8 },
            {"mheese",1.1 },
            {"mauce",0.9 }
        };

        private string type;
        private int weight;
        public string Type
        {
            get { return type; }
            private set 
            {
                if (!toppingTypeDict.ContainsKey(value.ToLower()))
                {
                    throw new ArgumentException($"Cannot place {this.Type} on top of your pizza");
                }
                type = value; 
            }
        }
        


        public int Weight
        {
            get { return weight; }
            private set 
            {
                if (value < 1 || value > 50)
                {
                    throw new ArgumentException($"{this.Type} weight should be in the range [1..50]");
                }
                weight = value; 
            }
        }
        public Topping(string type,int weight)
        {
            this.Type = type;
            this.Weight = weight;
        }
        public double Calories => 2 * Weight * toppingTypeDict[this.Type.ToLower()];
    }
}
