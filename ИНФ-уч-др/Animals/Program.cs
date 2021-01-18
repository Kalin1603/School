namespace Animals
{
    using System;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            string input = Console.ReadLine();

            while (input != "Beast!")
            {
                try
                {
                    string[] dataDog = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                    string name = dataDog[0];
                    int age;
                    if (!int.TryParse(dataDog[1], out age))
                    {
                        throw new ArgumentException("Invalid input!");
                    }

                    string gender = dataDog[2];


                    switch (input)
                    {
                        case "Dog":
                            Dog dog = new Dog(name, age, gender);
                            Console.WriteLine("Dog");
                            Console.WriteLine(dog.Result());
                            break;
                        case "Cat":
                            Cat cat = new Cat(name, age, gender);
                            Console.WriteLine("Cat");
                            Console.WriteLine(cat.Result());
                            break;
                        case "Frog":
                            Frog frog = new Frog(name, age, gender);
                            Console.WriteLine("Frog");
                            Console.WriteLine(frog.Result());
                            break;
                        case "Kitten":
                            Kitten kitten = new Kitten(name, age, "female");
                            Console.WriteLine("Kitten");
                            Console.WriteLine(kitten.Result());
                            break;
                        case "Tomcat":
                            Tomcat tomcat = new Tomcat(name, age, "male");
                            Console.WriteLine("Tomcat");
                            Console.WriteLine(tomcat.Result());
                            break;
                        default:
                            throw new ArgumentException("Invalid input!");
                    }
                }
                catch (ArgumentException ae)
                {
                    Console.WriteLine(ae.Message);
                }
                input = Console.ReadLine();
            }
        }
    }
 }

