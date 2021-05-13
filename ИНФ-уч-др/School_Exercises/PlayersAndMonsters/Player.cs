namespace PlayersAndMonsters
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public abstract class Player
    {
        private string username;
        private int health;
        public CardRepository cardRepository;

        protected Player(string username, int health, CardRepository cardRepository)
        {
            this.Username = username;
            this.Health = health;
            this.cardRepository = new CardRepository();
        }

        public string Username
        {
            get { return username; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Player's username cannot be null or an empty string.");
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
                    throw new ArgumentException("Player's health bonus cannot be less than zero.");
                }
                health = value;
            }
        }

        public bool IsDead { get; set; }

        public void TakeDamage(int damagePoints)
        {
            damagePoints -= damagePoints;
            if (damagePoints < 0)
            {
                throw new ArgumentException("Damage points cannot be less than zero.");
            }
        }

    }
}
