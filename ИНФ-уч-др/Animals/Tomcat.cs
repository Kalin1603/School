namespace Animals
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Tomcat : Animals
    {
        public Tomcat(string name, int age, string gender) : base(name, age, "male")
        {

        }

        public override string ProduceSound()
        {
            return $"MEOW";
        }
    }
}
