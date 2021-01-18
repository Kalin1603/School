namespace Животинско_царство
{
    using System;

    public class Program
    {
        public static void Main()
        {
            Cat cat = new Cat(5,"Coco");
            Dog dog = new Dog(6,"Puffy");

            Console.WriteLine(cat.MakeNoise());
            Console.WriteLine(cat.MakeTrick());

            Console.WriteLine(dog.MakeNoise());
            Console.WriteLine(dog.MakeTrick());
        }
    }
}
