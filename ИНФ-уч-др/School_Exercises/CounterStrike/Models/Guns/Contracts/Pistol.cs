﻿namespace CounterStrike.Models.Guns.Contracts
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Pistol : Gun
    {
        public Pistol(string name, int bulletsCount) : base(name, bulletsCount)
        {

        }

        public override int Fire()
        {
            if (BulletsCount - 1 < 0)
            {
                return 0;
            }
            else
            {
                this.BulletsCount --;
                return 1;
            }
        }
    }
}
