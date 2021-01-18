namespace Храна_за_домашни_любимци
{
    using System;
    using System.Text;

    public class Program
    {
        public static void Main()
        {
            Console.Write("Брой дни: ");
            int broiDni = int.Parse(Console.ReadLine());
            Console.Write("Общо количество храна: ");
            double obshtoKolichestvoHrana = double.Parse(Console.ReadLine());

            double biskviti = 0.0;
            int kolichestvoIzqdenaHranaKuche = 0;
            int kolichestvoIzqdenaHranaKotka = 0;

            for (int i = 1; i <= broiDni; i++)
            {
               int hranaKuche = int.Parse(Console.ReadLine());
               int hranaKotka = int.Parse(Console.ReadLine());

                kolichestvoIzqdenaHranaKuche += hranaKuche;
                kolichestvoIzqdenaHranaKotka += hranaKotka;

                if (i % 3 == 0)
                {
                     biskviti = (hranaKuche + hranaKotka) * 0.1 ;                   
                }

            }
            double obshtoIzqdenaHrana = kolichestvoIzqdenaHranaKuche + kolichestvoIzqdenaHranaKotka;
            Console.WriteLine();
            Console.WriteLine($"Общо изядена храна -> {obshtoIzqdenaHrana}");
            Console.WriteLine();

            double procentIzqdenaHrana = (obshtoIzqdenaHrana /  obshtoKolichestvoHrana) * 100;
            double procentIzqdenaHranaKuche = (kolichestvoIzqdenaHranaKuche / obshtoIzqdenaHrana) * 100;
            double procentIzqdenaHranaKotka = (kolichestvoIzqdenaHranaKotka / obshtoIzqdenaHrana) * 100;
          
            Console.WriteLine($"Total eaten biscuits: {Math.Round(biskviti)}gr.");
            Console.WriteLine($"{procentIzqdenaHrana:f2}% of the food has been eaten.");
            Console.WriteLine($"{procentIzqdenaHranaKuche:f2}% eaten from the dog.");
            Console.WriteLine($"{procentIzqdenaHranaKotka:f2}% eaten from the cat.");
        }
    }
}
