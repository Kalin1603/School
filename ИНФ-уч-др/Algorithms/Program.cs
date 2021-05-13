using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    private static List<int> nums = new List<int>();

    static void Main()
    {
        //Решение а)
        SumNegative();

        //Решение б)
        AveragePositiveNumbers();

        //Решение в)
        Console.Write("Enter a: ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Enter b: ");
        int b = int.Parse(Console.ReadLine());
        Console.Write("Enter c: ");
        int c = int.Parse(Console.ReadLine());

        int result = Product(Math.Abs(c - b)) * Product(a);
        Console.WriteLine($"Product (|{c}-{b}|) * Product ({a}) = {result}");
    }

    //Решение а)
    private static void SumNegative()
    {
        while (true)
        {
            Console.Write("Enter number: ");
            string input = Console.ReadLine();
            if (int.TryParse(input, out _))
            {
                int num = int.Parse(input);
                if (num == 0)
                {
                    break;
                }
                nums.Add(num);
            }
            else
            {
                Console.WriteLine("You enter NaN (not a number). Try again!");
            }
        }
        Console.WriteLine($"Sum: {nums.Where(x => x < 0).Sum()}");
    }

    //Решение б)
    private static void AveragePositiveNumbers()
    {
        int[] nums = new int[13];
        for (int i = 0; i < nums.Length; i++)
        {
            Console.Write($"Enter element [{i}]: ");
            nums[i] = int.Parse(Console.ReadLine());
        }
        Console.WriteLine($"Average: {nums.Where(x => x > 0 || x < -100).Average()}");
    }

    //Решение в)
    private static int Product(int k)
    {
        Random random = new Random();
        int[] numbers = new int[k];

        int product = 1;
        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = random.Next(-1000, 1000);

            bool isTrue = numbers[i] >= -10 && numbers[i] <= 10;
            if (isTrue)
            {
                product*=numbers[i];
            }
        }
        return product;
    }
}

