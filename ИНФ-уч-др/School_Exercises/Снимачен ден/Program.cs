namespace Снимачен_ден
{
    using System;

    public class Program
    {
        public static void Main()
        {
            int vremeSnimki = int.Parse(Console.ReadLine());
            int broiSceni = int.Parse(Console.ReadLine());
            int vremetraeneNaScena = int.Parse(Console.ReadLine());

            double podgotovkaTeren = vremeSnimki * 0.15;
            Console.WriteLine(podgotovkaTeren);
            int vremeZaZasnemane = broiSceni * vremetraeneNaScena;
            Console.WriteLine(vremeZaZasnemane);

            double neobhodimoVreme = podgotovkaTeren + vremeZaZasnemane;
            Console.WriteLine(neobhodimoVreme);

            if (neobhodimoVreme>vremeSnimki)
            {
                Console.WriteLine($"Time is up! To complete the movie you need {neobhodimoVreme - vremeSnimki} minutes.");
             
            }
            else
            {
                Console.WriteLine($"You managed to finish the movie on time! You have {vremeSnimki - neobhodimoVreme} minutes left");
            }
            
        }
    }
}
