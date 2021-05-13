namespace CounterStrike.Models.Players.Contracts
{
    using System;
    using CounterStrike.Models.Guns.Contracts;
    using CounterStrike.Utilities.Messages;

    public abstract class Player : IPlayer
    {
        private string username;
        private int health;
        private int armor;
        private IGun gun;
        private bool isAlive;

        protected Player(string username, int health, int armor, IGun gun)
        {
            this.username = username;
            this.health = health;
            this.armor = armor;
            this.gun = gun;
        }

        public string Username
        {
            get { return username; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(string.Format(ExceptionMessages.InvalidPlayerName));
                }
                username = value;
            }
        }

        public int Health
        {
            get { return health; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException(string.Format(ExceptionMessages.InvalidPlayerHealth));
                }
                health = value;
            }
        }

        public int Armor
        {
            get { return armor; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException(string.Format(ExceptionMessages.InvalidPlayerArmor));
                }
                armor = value;
            }
        }

        public IGun Gun
        {
            get { return gun; }
            set
            {
                if (value == null)
                {
                    throw new ArgumentException(string.Format(ExceptionMessages.InvalidGun));
                }
                gun = value;
            }
        }

        public bool IsAlive
        {
            get { return isAlive; }
            set
            {
                if (health > 0)
                {
                    value = true;
                }
                isAlive = value;
            }
        }

        public void TakeDamage(int points)
        {
            if (points <= Armor)
            {
                Armor -= points;
            }
            else if (points < Health)
            {
                int removeFromHealth = points - armor;
                Armor = 0;
                Health -= removeFromHealth;
            }
            else if (Health - points <= 0)
            {
                this.IsAlive = false;
            }
        }
    }
}
