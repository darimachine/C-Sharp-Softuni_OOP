using System;
using System.Collections.Generic;

namespace OOP_Inheritance
{
    public class MotorVehicle
    {
        public int transmission = 0;
        private int maxTransmission = 6;

        public void UpTransmission()
        {
            transmission++;
            if (transmission > maxTransmission)
            {
                transmission = 6;
            }
        }
        public void DownTransmission()
        {
            transmission--;
            if (transmission < 0)
            {
                transmission = 0;
            }
        }
        public void OpenDoor()
        {
            if (transmission == 0)
            {
                // TODO OPEN
            }
        }
    }
    class Car : MotorVehicle
    {
        
        void Move()
        {
            transmission++;
        }
        
    }
    class Motobike : MotorVehicle
    {

    }
    class Truck
    {
        private Stack<string> items;
        private int Capacity = 6;
        void Load(string item)
        {
            if (Capacity > items.Count)
            {
                this.items.Push(item);
            }
            
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
