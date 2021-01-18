namespace Рожден_ден
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Citizen
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Id { get; set; }
        public string BirthDate { get; set; }

        public override string ToString()
        {
            return $"Citizen {this.Name} {this.Age} {this.Id} {this.BirthDate}"; 
        }
    }
}
