namespace SpeedInformation
{
    using System;

    public class Program
    {
        public static void Main()
        {
            double speed = double.Parse(Console.ReadLine());

            if (speed == 10)
            {
                Console.WriteLine("slow");
            }

            else if (speed > 10 && speed <= 50)
            {
                Console.WriteLine("average");
            }

            else if (speed > 50 && speed <= 150)
            {
                Console.WriteLine("fast");
            }

            else
            {
                Console.WriteLine("extremely fast");
            }
        }
    }
}
