namespace Пазаруване
{
    using System;
    using System.Transactions;

    public class Program
    {
        public static void Main()
        {
            double Videocard = 250.00;

            Console.Write("Бюджет: ");
            double budget = double.Parse(Console.ReadLine());
            Console.Write("Брой видеокарти: ");
            int videocardNum = int.Parse(Console.ReadLine());
            Console.Write("Брой процесори: ");
            int processorNum = int.Parse(Console.ReadLine());
            Console.Write("Брой рам памет: ");
            int ramNum = int.Parse(Console.ReadLine());

            double videocardPrice = Videocard * videocardNum;
            Console.WriteLine();
            Console.WriteLine($"Цена на видеокарти -> {videocardPrice}лв.");

            double processorPrice = videocardPrice * 0.35;
            Console.WriteLine();
            Console.WriteLine($"Цена на процесор -> {processorPrice:f0}лв.");

            double ramPrice = videocardPrice * 0.1;
            double ramTotal = ramNum * ramPrice;
            Console.WriteLine();
            Console.WriteLine($"Цена на рам памет -> {ramTotal:f0}лв.");

            double total = videocardPrice + processorPrice + ramTotal;
            Console.WriteLine();
            Console.WriteLine($"Общо -> {total:f0}лв.");

            double sale = total - (total * 0.15);
            Console.WriteLine();
            Console.WriteLine($"Отстъпка -> {sale:f2}лв.");
            Console.WriteLine();
     
            double moneyLeft = budget - sale;
            if (sale <= budget)
            {             
                Console.WriteLine($"You have {moneyLeft:f2} leva left!");
            }
            else
            {
                double sale2 = total - (total * 0.15);
                double moneyNeed = sale2 - budget;
                Console.WriteLine($"Not enough money! You need {moneyNeed:f2} leva more!");
            }

        }
    }
}
