namespace CounterStrike.Models.Players.Contracts
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using CounterStrike.Models.Guns.Contracts;

    public class Terrorist : Player
    {
        public Terrorist(string username, int health, int armor, IGun gun) : base(username, health, armor, gun)
        {

        }
    }
}
