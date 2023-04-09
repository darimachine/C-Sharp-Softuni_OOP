using System;
using System.Collections.Generic;

namespace Encapsulation_Exercises
{
    class Dough
    {
        private const string DoughExceptionMessage= "Invalid type of dough";
        private const string WeightExceptionMessage = "Dough weight should be in the range [1..200].";
        private Dictionary<string, double> flourDict = new Dictionary<string, double>() 
        {
            {"white",1.5 },
            {"wholegrain",1 },
          
        };
        private Dictionary<string, double> bakingDict = new Dictionary<string, double>()
        {
            {"crispy",0.9 },
            {"chewy",1.1 },
            {"homemade",1.0 }

        };
        private string flourType;
        public string FlourType 
        {
            get=>flourType;
            private set {
                if(!flourDict.ContainsKey(value.ToLower()))
                {
                    throw new ArgumentException(DoughExceptionMessage);
                    
                }
                    flourType = value;
                
            } 
        }
        private string bakingTechnique;

        public string BakingTechnique
        {
            get { return bakingTechnique; }
            private set {
                if (!bakingDict.ContainsKey(value.ToLower()))
                {
                    throw new ArgumentException(DoughExceptionMessage);
                    
                }
                bakingTechnique = value;

            }
        }


        private int weight;

        public Dough(string flourType, string bakingTechnique, int weight)
        {
            this.FlourType = flourType;
            this.BakingTechnique = bakingTechnique;
            this.Weight = weight;
        }

        public int Weight
        {
            get { return weight; }
            private set 
            { 
                if(value<1 || value > 200)
                {
                    throw new ArgumentException(WeightExceptionMessage);
                }
                weight = value; 
            }
        }
        public double Calories => 2 * Weight * flourDict[this.FlourType.ToLower()]*bakingDict[this.BakingTechnique.ToLower()];
    }
}
