using System;

namespace NeedForSpeed
{
    class Vehicle
    {
        public Vehicle(int horsePower,double fuel)
        {

        }
        public double DefaultFuelConsumption { get; set; } = 1.25;
        public virtual double FuelConsumption { get; set; } 
        public double Fuel { get; set; }
        public int HorsePower { get; set; }
        public virtual void Drive(double kilometers)
        {
            this.Fuel = this.Fuel-kilometers / (100/FuelConsumption);
        }
        
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
