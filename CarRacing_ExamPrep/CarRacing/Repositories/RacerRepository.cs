using CarRacing.Models.Racers.Contracts;
using CarRacing.Repositories.Contracts;
using CarRacing.Utilities.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CarRacing.Repositories
{
    public class RacerRepository : IRepository<IRacer>
    {
        private List<IRacer> Racers;
        public RacerRepository()
        {
            this.Racers = new List<IRacer>();
        }
        public IReadOnlyCollection<IRacer> Models => this.Racers;

        public void Add(IRacer model)
        {
            if (model == null) { throw new ArgumentException(ExceptionMessages.InvalidAddRacerRepository); }
            this.Racers.Add(model);
        }

        public IRacer FindBy(string property)
        {
            return this.Racers.FirstOrDefault(x => x.Username == property);
        }

        public bool Remove(IRacer model)
        {
            return this.Racers.Remove(model);
        }
    }
}
