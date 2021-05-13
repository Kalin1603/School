namespace Сафари
{
    using System;
    public class Program
    {
        public static void Main()
        {

            double cenaEdinLiturGorivo = 2.10;
            int cenaEkskurzovod = 100;
            double otstupkaSubota = 0.1;
            double otstupkaNedelq = 0.2;

            double budget = double.Parse(Console.ReadLine());
            double litriGorivo = double.Parse(Console.ReadLine());
            string den = Console.ReadLine();

            double cenaGorivo = litriGorivo * cenaEdinLiturGorivo;
            Console.WriteLine();
            Console.WriteLine($"Цена на гориво -> {cenaGorivo:f2}");

            double obshtoEkskurzovod = cenaGorivo + cenaEkskurzovod;
            Console.WriteLine();
            Console.WriteLine($"Общо с екскурзовода -> {obshtoEkskurzovod:f2}");


            double otstupka = obshtoEkskurzovod - otstupkaNedelq * obshtoEkskurzovod;
            Console.WriteLine();
            Console.WriteLine($"Отстъпката за Неделя е -> {otstupka:f2}");

            double otstupka2 = obshtoEkskurzovod - otstupkaSubota * obshtoEkskurzovod;
            Console.WriteLine();
            Console.WriteLine($"Отстъпката за Събота е -> {otstupka2:f2}");


            if (budget >= otstupka)
            {
                double moneyLeft = budget - otstupka;
                Console.WriteLine();
                Console.WriteLine($"Safari time! Money left: {moneyLeft:f2} lv. ");
            }
            else
            {
                if (budget < otstupka2)
                {
                    double moneyNeed = otstupka2 - budget;
                    Console.WriteLine();
                    Console.WriteLine($"Not enough money! Money needed: {moneyNeed:f2} lv.");
                }
            }

        }
    }
}
