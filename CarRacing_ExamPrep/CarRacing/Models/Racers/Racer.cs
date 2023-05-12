using CarRacing.Models.Cars.Contracts;
using CarRacing.Models.Racers.Contracts;
using CarRacing.Utilities.Messages;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarRacing.Models.Racers
{
    public abstract class Racer : IRacer
    {
        public Racer(string username, string racingBehavior, int drivingExperience, ICar car)
        {
            this.Username = username;
            this.RacingBehavior = racingBehavior;
            this.DrivingExperience = drivingExperience;
            this.Car = car;
        }
        private string username;
        public string Username
        {
            get => username;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(ExceptionMessages.InvalidRacerName);
                }
                this.username = value;
            }
        }
        private string racingBehavior;
        public string RacingBehavior
        {
            get => racingBehavior;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(ExceptionMessages.InvalidRacerBehavior);
                }
                this.racingBehavior = value;
            }
        }
        private int drivingexperience;
        public int DrivingExperience
        {
            get => drivingexperience;
            set
            {
                if (value<0 || value>100)
                {
                    throw new ArgumentException(ExceptionMessages.InvalidRacerDrivingExperience);
                }
                this.drivingexperience = value;
            }
        }
        private ICar car;
        public ICar Car
        {
            get => car;
            set
            {
                if (value == null)
                {
                    throw new ArgumentException(ExceptionMessages.InvalidRacerCar);
                }
                this.car = value;
            }
        }

        public bool IsAvailable()
        {
            return Car.FuelAvailable >= this.Car.FuelConsumptionPerRace;
        }

        public virtual void Race()
        {
            Car.Drive();
        }
        
    }
}
