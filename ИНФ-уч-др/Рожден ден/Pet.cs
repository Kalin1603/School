namespace Рожден_ден
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Pet
    {
        public string Name { get; set; }
        public string BirthDate { get; set; }

        public override string ToString()
        {
            return $"Pet {this.Name} {this.BirthDate}";
        }
    }
}
