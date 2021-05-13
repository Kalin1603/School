namespace Котешка_разходка
{
    using System;

    public class Program
    {
        public static void Main()
        {
            int minRazhodkaDen = int.Parse(Console.ReadLine());
            int brRazhodki = int.Parse(Console.ReadLine());
            int kotkaPrietiKalorii = int.Parse(Console.ReadLine());

            int totalMin = minRazhodkaDen * brRazhodki;
            Console.WriteLine(totalMin);
            int izgoreniKalorii = totalMin * 5;
            Console.WriteLine(izgoreniKalorii);
            double prietiKalorii = kotkaPrietiKalorii * 0.5;
            Console.WriteLine(prietiKalorii);

            if (izgoreniKalorii>prietiKalorii)
            {
                Console.WriteLine($"Yes, the walk for your cat is enough. Burned calories per day: {izgoreniKalorii}.");
            }
            else
            {
                Console.WriteLine($"No,  the  walk  for  your  cat  is  not  enough. Burned calories per day:  {izgoreniKalorii}.");
            }

        }
    }
}
