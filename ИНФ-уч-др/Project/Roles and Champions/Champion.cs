namespace Project.Roles_and_Champions
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Champion : Character
    {
        private string name;
        private int level;

        public Champion(string role,string name,int level) : base(role)
        {
            this.Name = name;
            this.Level = level;
        }

        public string Name
        {
            get { return name; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Invalid name!");
                }
                name = value;
            }
        }

        public int Level
        {
            get { return level; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Invalid level!");
                }
                level = value;
            }
        }

        public string Fight(Champion champion)
        {
            if (this.Level > champion.Level)
            {
                return $"{this.Name}-vs-{champion.Name}-{this.Name} is the winner!!!";
            }
            else
            {
                return $"{this.Name}-vs-{champion.Name}-{champion.Name} is the winner";
            }
        }

        public override string ToString()
        {
            return base.ToString()+ $" - {this.Name} is {this.Level} level";
        }
    }
}
