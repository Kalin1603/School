namespace Животинско_царство
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Cat : Animal
    {
        public Cat(int age, string name) : base(age, name)
        {

        }

        public override string MakeNoise()
        {
            return "Meow!"+base.MakeNoise();
        }

        public override string MakeTrick()
        {
            return "No trick for you! I'm too lazy!";
        }
    }
}
