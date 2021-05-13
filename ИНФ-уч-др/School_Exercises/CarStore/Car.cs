namespace CarStore
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Car
    {
        private int number;
        private double price;

        public Car(int number, double price)
        {
            this.Number = number;
            this.Price = price;
        }

        public string Brand { get; set; }

        public string Model { get; set; }
        

        public double Price
        {
            get { return price; }
            set { price = value; }
        }


        public int Number
        {
            get { return number; }
            set { number = value; }
        }

        public override string ToString()
        {
            return $"Car number {this.Number} costs {this.Price}";
        }
        
    }
}
