using System;

namespace Abstract_Classes
{
    interface ICar
    {
        public string Model { get; set; }
        public string Color { get; set; }
        
        string Start();
        string Stop();
    }
    interface IElectricCar
    {
        public int Battery { get; set; }
    }
    class Tesla : ICar, IElectricCar
    {
        public Tesla(string model, string color, int battery)
        {
            Model = model;
            Color = color;
            Battery = battery;
        }

        public string Model { get; set ; }
        public string Color { get; set; }
        public int Battery { get; set; }

        public string Start()
        {
            return "Vrum vrum";
        }

        public string Stop()
        {
            return "";
        }
    }
    class Seat : ICar
    {
        public string Model { get; set ; }
        public string Color { get ; set ; }

        public string Start()
        {
            throw new NotImplementedException();
        }

        public string Stop()
        {
            throw new NotImplementedException();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            ICar Car = new Tesla("tels1", "black", 23);
            Console.WriteLine(Car.Start());
            Console.WriteLine(Car.Stop());
        }
    }
}
