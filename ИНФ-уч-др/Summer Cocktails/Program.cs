namespace Summer_Cocktails
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class Program
    {
        private static int mimosa = 0;
        private static int daiquiri = 0;
        private static int sunshine = 0;
        private static int mojito = 0;


        private static Queue<int> ingredients = new Queue<int>(ReadArr());
        private static Stack<int> freshnessValue = new Stack<int>(ReadArr());
        
        public static void Main()
        {
            MakeCocktail();
            Output();
        }
        private static void MakeCocktail()
        {
            while (true)
            {
                if (!(ingredients.Any() && freshnessValue.Any()))
                {
                    break;
                }
                int currentIngredients = ingredients.Dequeue();
                int currentFreshnessValue = freshnessValue.Pop();
                int multipl = currentIngredients * currentFreshnessValue;
                switch (multipl)
                {
                    case 150:
                        mimosa++;
                        break;
                    case 250:
                        daiquiri++;
                        break;
                    case 300:
                        sunshine++;
                        break;
                    case 400:
                        mojito++;
                        break;
                    default:
                        currentFreshnessValue += 5;
                        freshnessValue.Push(currentFreshnessValue);
                        break;
                }
            }
        }
        private static void Output()
        {
            Console.WriteLine();

            if (mimosa > 0 && daiquiri > 0 && sunshine > 0 && mojito > 0)
            {
                Console.WriteLine("It's party time! The cocktails are ready!");
            }
            else
            {
                Console.WriteLine("What a pity! You didn't manage to prepare all cocktails.");
            }

            Console.WriteLine();
            
            if (ingredients.Any())
            {
                Console.WriteLine($"Ingredients left: {string.Join(", ", ingredients)}");
            }
            
            
            Console.WriteLine($"#Daiquiri --> {daiquiri}");
            Console.WriteLine($"#Mimosa --> {mimosa}");
            Console.WriteLine($"#Mojito --> {mojito}");
            Console.WriteLine($"#Sunshine --> {sunshine}");
        }
        public static int[] ReadArr()
        {
            return Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();
        }
    }
}
