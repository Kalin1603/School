namespace Дартс
{
    using System;

   public class Program
    {
       public static void Main()
        {
            Console.Write("Name: ");
            string name = Console.ReadLine();
            int currentPoints = StartingPoint;
            int succShots = 0;
            int unSuccShots = 0;

            while (currentPoints != 0)
            {
                Console.Write("Field: ");
                string field = Console.ReadLine();

                if (field == Retire)
                {
                    break;
                }

                Console.Write("Points: ");
                int points = int.Parse(Console.ReadLine());

                switch (field)
                {
                    case Single:
                        //Не променя брой точки
                        points *= 1;
                        break;
                    case Double:
                        points *= 2;
                        break;
                    case Triple:
                        points *= 3;
                        break;
                    default:
                        break;
                }

                if (points <= currentPoints)
                {
                    currentPoints -= points;
                    succShots++;
                }
                else
                {
                    unSuccShots++;
                }
            }

            if (currentPoints == 0)
            {
                Console.WriteLine($"{name} won the leg with {succShots} shots.");
            }
            else
            {
                Console.WriteLine($"{name} retired after {unSuccShots} unsuccessful shots.");
            }
        }

        const int StartingPoint = 301;
        const string Single = "Single";
        const string Double = "Double";
        const string Triple = "Triple";
        const string Retire = "Retire";

    }
}
