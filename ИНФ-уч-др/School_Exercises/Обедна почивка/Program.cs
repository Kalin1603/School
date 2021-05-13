namespace Обедна_почивка
{
    using System;

    public class Program
    {
        public static void Main()
        {
            string name = Console.ReadLine();
            int produljitelnostEpizod = int.Parse(Console.ReadLine());
            int produljitelnostPochivka = int.Parse(Console.ReadLine());

            double vremeObqd = produljitelnostPochivka * 1 / 8.0;
            Console.WriteLine(vremeObqd);
            double vremeOtdih = produljitelnostPochivka * 1 / 4.0;
            Console.WriteLine(vremeOtdih);
            double ostanaloVreme = produljitelnostPochivka - vremeObqd - vremeOtdih;
            Console.WriteLine(ostanaloVreme);

            if (ostanaloVreme>=produljitelnostEpizod)
            {
                Console.WriteLine($"You have enough time to watch {name} and left with {ostanaloVreme - produljitelnostEpizod} minutes free time.");
            }
            else
            {
                Console.WriteLine($"You don't have enough time to watch {name}, you need {Math.Ceiling(produljitelnostEpizod - ostanaloVreme)} more minutes.");
            }
        }
    }
}
