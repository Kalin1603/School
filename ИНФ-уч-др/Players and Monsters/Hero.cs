namespace Players_and_Monsters
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Hero
    {
        public string Username { get; set; }
        public int Level { get; set; }

        public Hero(string username, int level)
        {
            this.Username = username;
            this.Level = level;
        }

        public override string ToString()
        {
            return $"{this.GetType().Name} Username: {this.Username} Level: {this.Level}";
        }
    }
}
