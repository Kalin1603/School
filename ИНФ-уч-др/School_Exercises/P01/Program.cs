
namespace P01
{
    using System;

    public class Program
    {
        public static void Main()
        {
            const decimal nailonPrice = 1.50m;
            const decimal pricePaint = 14.50m;
            const decimal paintThinnerPrice = 5m;

            int nailon = int.Parse(Console.ReadLine());
            int paint = int.Parse(Console.ReadLine());
            int PaintThinner = int.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());

            nailon += 2;

            decimal nailonExpenses = nailon * nailonPrice;
            double nPaint = paint * 1.1;

            decimal paintExpenses = (decimal)nPaint * pricePaint;
            decimal thinnerExpenses = PaintThinner * paintThinnerPrice;
            decimal totalExpenses = nailonExpenses + paintExpenses + thinnerExpenses + 0.40m;

            decimal workerExpenses = totalExpenses * 0.3m * hours;
            totalExpenses += workerExpenses;

            Console.WriteLine($"Total expenses: {totalExpenses:f2} lv.");

        }
    }
}
