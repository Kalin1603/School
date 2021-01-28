namespace Farm
{
    public abstract class Animal
    {
        public string AnimalName { get; set; }

        public string AnimalType { get; set; }

        public double AnimalWeight { get; set; }

        public int FoodEaten { get; set; }

        public abstract string MakeSound();

        public abstract string Eat(Food food);
    }
}
