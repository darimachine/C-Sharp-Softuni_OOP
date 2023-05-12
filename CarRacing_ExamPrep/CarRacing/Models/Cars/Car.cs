using CarRacing.Utilities.Messages;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarRacing.Models.Cars.Contracts
{
    public abstract class Car : ICar
    {
        public Car(string make, string model, string VIN, int horsePower,
            double fuelAvailable, double fuelConsumptionPerRace)
        {
            this.Make = make;
            this.Model = model;
            this.VIN = VIN;
            this.HorsePower = horsePower;
            this.FuelAvailable = fuelAvailable;
            this.FuelConsumptionPerRace = fuelConsumptionPerRace;
        }
        private string make;
        public string Make 
        {
            get => make;
            set
            {
                
                if (value==null || value == "")
                {
                    throw new ArgumentException(ExceptionMessages.InvalidCarMake);
                }
                this.make = value;
            }
        }
        private string model;
        public string Model
        {
            get => model;
            set
            {
                if (value == null || value == "")
                {
                    throw new ArgumentException(ExceptionMessages.InvalidCarModel);
                }
                this.model = value;
            }
        }



        private string vin;
        public string VIN
        {
            get => vin;
            set
            {
                if (value.Length!=17)
                {
                    throw new ArgumentException(ExceptionMessages.InvalidCarVIN);
                }
                this.vin = value;
            }
        }
        private int horsePower;
        public int HorsePower
        {
            get => horsePower;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException(ExceptionMessages.InvalidCarHorsePower);
                }
                this.horsePower = value;
            }
        }

        private double fuelAvailable;
        public double FuelAvailable
        {
            get => fuelAvailable;
            set
            {
                if (value < 0)
                {
                    this.fuelAvailable = 0;
                }
                else
                {
                    this.fuelAvailable = value;
                }
               
            }
        }
        private double fuelConsumptionPerRace;
        public double FuelConsumptionPerRace
        {
            get => fuelConsumptionPerRace;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException(ExceptionMessages.InvalidCarFuelConsumption);
                }
                else
                {
                    this.fuelConsumptionPerRace = value;
                }

            }
        }

        public virtual void Drive()
        {
            this.FuelAvailable = this.FuelAvailable - this.FuelConsumptionPerRace;
        }
    }
}
