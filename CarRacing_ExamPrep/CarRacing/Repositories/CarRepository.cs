using CarRacing.Models.Cars.Contracts;
using CarRacing.Repositories.Contracts;
using CarRacing.Utilities.Messages;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarRacing.Repositories
{
    public class CarRepository : IRepository<ICar>
    {

        private List<ICar> Cars;
        public CarRepository()
        {
            this.Cars = new List<ICar>();
        }
        public IReadOnlyCollection<ICar> Models => this.Cars;

        public void Add(ICar model)
        {
            if(model == null) { throw new ArgumentException(ExceptionMessages.InvalidAddCarRepository); }
            this.Cars.Add(model);
        }

        public bool Remove(ICar model)
        {
            return this.Cars.Remove(model);
        }

        public ICar FindBy(string property)
        {
            ICar car = this.Cars.Find(x => x.VIN == property);
            if (car!=null)
            {
                return car;
            }
            else
            {
                return null;
            }
        }
    }
}
