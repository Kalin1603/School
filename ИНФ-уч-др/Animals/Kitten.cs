namespace Animals
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Kitten : Animals
    {
        public Kitten(string name, int age, string gender) : base(name, age, "female")
        {

        }

        public override string ProduceSound()
        {
            return $"Meow";
        }
    }
}
