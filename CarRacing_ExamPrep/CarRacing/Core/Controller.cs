using CarRacing.Core.Contracts;
using CarRacing.Models.Cars;
using CarRacing.Models.Cars.Contracts;
using CarRacing.Models.Maps.Contracts;
using CarRacing.Models.Racers;
using CarRacing.Models.Racers.Contracts;
using CarRacing.Repositories;
using CarRacing.Utilities.Messages;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using CarRacing.Models.Maps;

namespace CarRacing.Core
{
    public class Controller : IController
    {
        private CarRepository cars;
        private RacerRepository racers;
        private IMap map;
        public Controller()
        {
            this.cars = new CarRepository();
            this.racers = new RacerRepository();
            this.map = new Map();
           
        }
        public string AddCar(string type, string make, string model, string VIN, int horsePower)
        {
            ICar car;
            if(type == "SuperCar")
            {
                car = new SuperCar(make, model, VIN, horsePower);
            }
            else if (type == "TunedCar")
            {
                car = new TunedCar(make, model, VIN, horsePower);
            }
            else
            {
                throw new ArgumentException(ExceptionMessages.InvalidCarType);
            }
            cars.Add(car);
            return $"Successfully added car {car.Make} {car.Model} ({VIN}).";
            
        }

        public string AddRacer(string type, string username, string carVIN)
        {
            IRacer racer;
            ICar car = cars.FindBy(carVIN);
            if(car == null)
            {
                throw new ArgumentException(ExceptionMessages.CarCannotBeFound);
            }
            if(type== "ProfessionalRacer")
            {
                racer = new ProfessionalRacer(username, car);
            }
            else if(type== "StreetRacer")
            {
                racer = new StreetRacer(username, car);
            }
            else
            {
                throw new ArgumentException(ExceptionMessages.InvalidRacerType);
            }
            racers.Add(racer);
            return $"Successfully added racer {racer.Username}.";
        }

        public string BeginRace(string racerOneUsername, string racerTwoUsername)
        {
            var racerOne = this.racers.FindBy(racerOneUsername);
            var racerTwo = this.racers.FindBy(racerTwoUsername);
            if(racerOne == null)
            {
                throw new ArgumentException($"Racer {racerOneUsername} cannot be found!");
            }
            if (racerTwo == null)
            {
                throw new ArgumentException($"Racer {racerTwoUsername} cannot be found!");
            }
            var result = map.StartRace(racerOne, racerTwo);
            return result;
            
        }

        public string Report()
        {
            StringBuilder result = new StringBuilder();
            var racersModifed=racers.Models.OrderByDescending(x => x.DrivingExperience).ThenBy(x => x.Username);
            foreach (var racer in racersModifed)
            {
                result.AppendLine($"{racer.GetType().Name}: {racer.Username}");
                result.AppendLine($"--Driving behavior: { racer.RacingBehavior}");
                result.AppendLine($"--Driving experience: { racer.DrivingExperience}");
                result.AppendLine($"--Car: {racer.Car.Make} {racer.Car.Model} ({racer.Car.VIN})");
            }
            return result.ToString().TrimEnd();
        }
    }
}
