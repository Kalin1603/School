namespace Приход_от_филм
{
    using System;

    public class Program
    {
       public  static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int dni = int.Parse(Console.ReadLine());
            int broiBileti = int.Parse(Console.ReadLine());
            double cenaBilet = double.Parse(Console.ReadLine());
            int procentKino = int.Parse(Console.ReadLine());

            double cenaBiletZaDen = broiBileti * cenaBilet;
            Console.WriteLine($"Cena na biletite za den -> {cenaBiletZaDen}");

            double cqlPeriod = dni * cenaBiletZaDen;
            Console.WriteLine($"Prihod za cql period -> {cqlPeriod}");

            double procentPrihod = cqlPeriod * procentKino / 100;
            Console.WriteLine($"Procent ot prihodite -> {procentPrihod}");

            double total = cqlPeriod - procentPrihod;

            Console.WriteLine($"The profit from the movie {name} is {total} lv.");
        }
    }
}
