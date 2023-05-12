using CarRacing.Models.Maps.Contracts;
using CarRacing.Models.Racers.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarRacing.Models.Maps
{
    public class Map : IMap
    {
        public string StartRace(IRacer racerOne, IRacer racerTwo)
        {
            double resultOne=0.0, resultTwo=0.0;
            
            if (!racerOne.IsAvailable() && racerTwo.IsAvailable()) 
            {
                return $"{racerTwo.Username} wins the race! {racerOne.Username} was not available to race!";
            }
            if(racerOne.IsAvailable() && !racerTwo.IsAvailable())
            {
                return $"{racerOne.Username} wins the race! {racerTwo.Username} was not available to race!";
            }
            if(!racerOne.IsAvailable() && !racerTwo.IsAvailable())
            {
                return $"Race cannot be completed because both racers are not available!";
            }

            racerOne.Race();

            racerTwo.Race();

            if (racerOne.RacingBehavior == "strict")
            {
                resultOne = racerOne.Car.HorsePower * racerOne.DrivingExperience * 1.2;
            }
            else
            {
                resultOne = racerOne.Car.HorsePower * racerOne.DrivingExperience * 1.1;
            }
            if (racerTwo.RacingBehavior == "strict")
            {
                resultTwo = racerTwo.Car.HorsePower * racerTwo.DrivingExperience * 1.2;
            }
            else
            {
                resultTwo = racerTwo.Car.HorsePower * racerTwo.DrivingExperience * 1.1;
            }

            if (resultOne > resultTwo)
            {
                return $"{ racerOne.Username} has just raced against { racerTwo.Username}! {racerOne.Username} is the winner!";
            }
            else if (resultOne==resultTwo)
            {
                return $"{ racerOne.Username} has just raced against { racerTwo.Username}! They are both equal";
            }
            else
            {
                return $"{ racerOne.Username} has just raced against { racerTwo.Username}! {racerTwo.Username} is the winner!";
            }

        }
    }
}
