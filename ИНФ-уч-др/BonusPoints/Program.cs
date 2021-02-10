namespace BonusPoints
{
    using System;

    public class Program
    {
        public static void Main()
        {
            Console.Write("Въведете число: ");
            int startPoints = int.Parse(Console.ReadLine());

            double bonusPonts = 0.0;

            if (startPoints % 2 == 0)
            {
                bonusPonts += 1.0;
            }

            if (startPoints % 10 == 5)
            {
                bonusPonts += 2.0;
            }

            if (startPoints <= 100)
            {
                bonusPonts += 5.0;
            }

            else if (startPoints > 100 && startPoints < 1000)
            {
                bonusPonts = bonusPonts + (startPoints * 0.20);
            }

            else if (startPoints > 1000)
            {
                bonusPonts = bonusPonts + (startPoints * 0.10); ;
            }

            Console.WriteLine($"Bonus points -> {bonusPonts}");

            double total = startPoints + bonusPonts;
            Console.WriteLine($"Total -> {total}");
        }
    }
}
