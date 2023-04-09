using System;
using System.Collections.Generic;
using System.Linq;

namespace FootballTeam
{
    class Team
    {
        private List<Player> numberOfPlayers;
        private string name;

        public string Name
        {
            get { return name; }
            private set 
            { 
                if(value==""|| value==null|| value==" ")
                {
                    throw new ArgumentException("A name should not be empty.");
                }
                name = value; 
            }
        }
        public Team(string name)
        {
            this.numberOfPlayers = new List<Player>();
            this.Name = name;
        }
        public double Rating()
        {
            return Math.Ceiling(numberOfPlayers.Average(x => x.skillLevel()));
        }
        public void AddPlayer(Player player)
        {

            numberOfPlayers.Add(player);
        }
        public void RemovePlayer(Player player)
        {
            
               numberOfPlayers.Remove(player);
            
            
        }


    }
    class Player 
    {
        private string name;
        public string Name 
        { 
            get=>name;
            private set 
            {
                if (value == "" || value == null || value == " ")
                {
                    throw new ArgumentException("A name should not be empty.");
                }
                name = value;
            }
        }
        public Player(string name, Stats stats)
        {
            this.Name = name;
            this.Stats = stats;
        }
        private Stats Stats { get; set; }
        public double skillLevel()
        {
            return (Stats.Endurance + Stats.Sprint + Stats.Dribble+Stats.Passing+Stats.Shooting)/5.00;
            
        }

    }
    class Stats
    {
        private int endurance;
        private int sprint;
        private int dribble;
        private int passing;
        private int shooting;

        public Stats(int endurance, int sprint, int dribble, int passing, int shooting)
        {
            this.Endurance = endurance;
            this.Sprint = sprint;
            this.Dribble = dribble;
            this.Passing = passing;
            this.Shooting = shooting;
        }

        public int Endurance 
        { 
            get=>endurance;
            private set 
            {
                if (value < 0 || value > 100)
                {
                    //throw new ArgumentException($"Endurance should be between 0 and 100.");
                    Console.WriteLine($"Endurance should be between 0 and 100.");
                    
                }
                else
                {
                    this.endurance = value;
                }
                
            } 
        }
        public int Sprint 
        { 
            get=>sprint;
            private set 
            {
                if (value < 0 || value > 100)
                {
                    //throw new ArgumentException($"Sprint should be between 0 and 100.");
                    Console.WriteLine($"Sprint should be between 0 and 100.");
                }
                else
                {
                    this.sprint = value;
                }
                
            } 
        }
        public int Dribble 
        { 
            get=>dribble;
            private set 
            {
                if (value < 0 || value > 100)
                {
                    //throw new ArgumentException($"Dribble should be between 0 and 100.");
                    Console.WriteLine($"Dribble should be between 0 and 100.");
                }
                else 
                {
                    this.dribble = value;
                }
                
            } 
        }
        public int Passing 
        { 
            get=>passing;
            private set 
            {
                if (value < 0 || value > 100)
                {
                    //throw new ArgumentException($"Passing should be between 0 and 100.");
                    Console.WriteLine($"Passing should be between 0 and 100.");

                }
                else
                {
                    this.passing = value;
                }
               
            } 
        }
        public int Shooting 
        { 
            get=>shooting;
            private set
            {
                if (value < 0 || value > 100)
                {
                    //throw new ArgumentException($"Shooting should be between 0 and 100.");
                    Console.WriteLine($"Shooting should be between 0 and 100.");
                }
                else 
                {
                    this.shooting = value;
                }
                
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var command = Console.ReadLine();
            List<Team> teams = new List<Team>();
            List<Player> players = new List<Player>();
            while (command != "END")
            {
                var line = command.Split(";");
                string action = line[0];
                if (action == "Team")
                {
                    Team team = new Team(line[1]);
                    teams.Add(team);
                }
                else if (action == "Add")
                {
                    if (teams.Any(x => x.Name == line[1]))
                    {
                        int[] stats=line.Skip(3).Select(int.Parse).ToArray();
                        Stats playerStats = new Stats(stats[0], stats[1], stats[2], stats[3], stats[4]);
                        Team singleTeam = teams.Where(x => x.Name == line[1]).FirstOrDefault();
                        if (!(stats.Max(x => x) > 100))
                        {
                            Player player = new Player(line[2], playerStats);
                            players.Add(player);
                            
                            singleTeam.AddPlayer(player);
                        }
                    }
                    else
                    {
                        Console.WriteLine($"Team {line[1]} does not exist.");
                    }
                }
                else if (action == "Remove")
                {
                    if (teams.Any(x => x.Name == line[1]))
                    {

                        Team singleTeam = teams.Where(x => x.Name == line[1]).FirstOrDefault();
                        Player player = players.Where(x => x.Name == line[2]).FirstOrDefault();
                        if (player==null)
                        {
                            Console.WriteLine($"Player {line[2]} is not in {line[1]} team.");
                        }
                        else
                        {
                            singleTeam.RemovePlayer(player);
                        }
                        
                    }
                    else
                    {
                        Console.WriteLine($"Team {line[1]} does not exist.");
                    }
                }
                else if (action == "Rating")
                {
                    if (teams.Any(x => x.Name == line[1]))
                    {
                        Team singleTeam = teams.Where(x => x.Name == line[1]).FirstOrDefault();
                        
                        Console.WriteLine($"{singleTeam.Name} - {singleTeam.Rating()}");
                    }
                    else
                    {
                        Console.WriteLine($"Team {line[1]} does not exist.");
                    }
                }
                command = Console.ReadLine();
            }
        }
    }
}
