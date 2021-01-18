namespace Скоростно_изкачване
{
    using System;

    public class Program
    {
        public static void Main()
        {
            double recordSek = double.Parse(Console.ReadLine());
            double distanceMeters = double.Parse(Console.ReadLine());
            double timeSek = double.Parse(Console.ReadLine());

            double clime = distanceMeters * timeSek;
            Console.WriteLine(clime);
            double everyMeters = Math.Floor(distanceMeters / 50) * 30;
            Console.WriteLine(everyMeters);
            double totalTime = clime + everyMeters;

            if (totalTime<recordSek)
            {
                Console.WriteLine($"Yes! The new record is {totalTime:f2} seconds.");
            }
            else
            {
                Console.WriteLine($"No! He was {totalTime - recordSek:f2} seconds slower.");
            }
        }
    }
}
