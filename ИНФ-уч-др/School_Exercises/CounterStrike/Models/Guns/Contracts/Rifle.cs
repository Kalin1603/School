namespace CounterStrike.Models.Guns.Contracts
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Rifle : Gun
    {
        public Rifle(string name, int bulletsCount) : base(name, bulletsCount)
        {

        }

        public override int Fire()
        {
            if (BulletsCount - 10 < 0)
            {
                return 0;
            }
            else
            {
                this.BulletsCount -= 10;
                return 10;
            }
        }
    }
}
