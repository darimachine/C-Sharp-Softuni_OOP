using System;

namespace Players_Monsters
{
    class Hero
    {
        public Hero(string username, int level)
        {
            this.Username = username;
            this.Level = level;
        }

        public string Username { get; set; }
        public int Level { get; set; }
        public override string ToString()
        {
            return $"Type: {this.GetType().Name} Username: {this.Username} Level: {this.Level}";
        }

    }

    class StartUp
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
