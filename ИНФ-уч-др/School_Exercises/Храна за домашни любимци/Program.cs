namespace Храна_за_домашни_любимци
{
    using System;

    public class Program
    {
        public static void Main()
        {
            int broiDni = int.Parse(Console.ReadLine());
            double obshtoKolichestvoHrana = double.Parse(Console.ReadLine());
            double biskviti = 0;
            int kolichestvoIzqdenaHranaKuche = 0;
            int kolichestvoIzqdenaHranaKotka = 0;

            for (int i = 1; i <= broiDni; i++)
            {
                if (broiDni % 3 == 0)
                {
                    double biskvitiBonus = (kolichestvoIzqdenaHranaKotka + kolichestvoIzqdenaHranaKotka) * 0.1;
                }

                 kolichestvoIzqdenaHranaKuche = int.Parse(Console.ReadLine());
                 kolichestvoIzqdenaHranaKotka = int.Parse(Console.ReadLine());
            }

            double obshtoIzqdenaHrana = kolichestvoIzqdenaHranaKuche + kolichestvoIzqdenaHranaKotka;
        }
    }
}
