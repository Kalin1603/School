using System;
namespace SingleInheritance
{
    public class Program
    {
        static void Main()
        {
            Animal animal = new Animal();
            Console.WriteLine(animal.Eat());

            Dog dog = new Dog();
            Console.WriteLine(dog.Bark());

            Puppy puppy = new Puppy();
            Console.WriteLine(puppy.Weep());

            Cat cat = new Cat();
            Console.WriteLine(cat.Meow());
        }
    }
}
