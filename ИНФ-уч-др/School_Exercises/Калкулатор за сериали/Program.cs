namespace Калкулатор_за_сериали
{
    using System;
    public class Program
    {
        public static void Main()
        {
            string name = Console.ReadLine();
            int broiSezoni = int.Parse(Console.ReadLine());
            int broiEpizodi = int.Parse(Console.ReadLine());
            double vremetraene = double.Parse(Console.ReadLine());

            double produljitelnostNaReklami = 0.2 * vremetraene;         
            Console.WriteLine(produljitelnostNaReklami);
            double produljitelnostNaEpizod = vremetraene + produljitelnostNaReklami;
            Console.WriteLine(produljitelnostNaEpizod);
            double dopulnitelnoVreme = broiSezoni * 10;
            Console.WriteLine(dopulnitelnoVreme);

            double total = produljitelnostNaEpizod * broiEpizodi * broiSezoni + dopulnitelnoVreme;

            Console.WriteLine($"Total time needed to watch the {name} series is {total} minutes.");
        }
    }
}
