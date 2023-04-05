using System.Collections.Generic;

namespace Encapsulation_Zad1
{
    class Team
    {
        private string name;
        private List<Person> firstTeam;
        private List<Person> reserveTeam;
        public Team(string name)
        {
            this.name = name;
            firstTeam = new List<Person>();
            reserveTeam = new List<Person>();
        }
        public string Name { get; set; }
        public IReadOnlyList<Person> FirstTeam => this.firstTeam;
        public IReadOnlyList<Person> ReserveTeam => this.reserveTeam;
        public void AddPlayer(Person person)
        {
            if (person.Age < 40)
            {
                this.firstTeam.Add(person);
            }
            else
            {
                this.reserveTeam.Add(person);
            }
            
        }
    }
}
