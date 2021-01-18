namespace Рожден_ден
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Robot
    {
        public string Model { get; set; }
        public string Id { get; set; }

        public override string ToString()
        {
            return $"Robot {this.Model} {this.Id}";
        }
    }
}
