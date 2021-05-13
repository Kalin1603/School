
namespace Церемония_за_Оскарите
{
    using System;

    public class Program
    {
        public static void Main()
        {
            int naemZaplata = int.Parse(Console.ReadLine());

            double cenaZaStatuetki = naemZaplata - naemZaplata * 0.3 ;
            double cenaZaKeturing = cenaZaStatuetki - cenaZaStatuetki * 0.15;
            double cenaZaOzvuchavane = cenaZaKeturing / 2 ;

            double total = cenaZaStatuetki + cenaZaKeturing + cenaZaOzvuchavane + naemZaplata;

            Console.WriteLine($"{total:f2}");


        }
    }
}
