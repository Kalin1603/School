namespace Животинско_царство
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Dog : Animal
    {
        public Dog(int age, string name) : base(age, name)
        {

        }

        public override string MakeNoise()
        {
            return "Woof!" + base.MakeNoise();
        }

        public override string MakeTrick()
        {
            return "Hold my paw, human!";
        }
    }
}
