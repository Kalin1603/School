namespace CounterStrike.Models.Guns.Contracts
{
    using CounterStrike.Utilities.Messages;
    using System;
    using System.Collections.Generic;
    using System.Text;

    public abstract class Gun : IGun
    {
        private string name;
        private int bulletsCount;

        public Gun(string name, int bulletsCount)
        {
            this.Name = name;
            this.BulletsCount = bulletsCount;
        }

        public string Name
        {
            get { return name; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(string.Format(ExceptionMessages.InvalidGunName));
                }
                name = value;
            }
        }

        public int BulletsCount
        {
            get { return bulletsCount; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException(string.Format(ExceptionMessages.InvalidGunBulletsCount));
                }
                bulletsCount = value;
            }
        }

        public abstract int Fire();
        
    }
}
