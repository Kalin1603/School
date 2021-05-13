using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

class Program
{
    public static void Main()
    {
        Queue<int> firstBox = new Queue<int>(ReadArr());
        Stack<int> secondBox = new Stack<int>(ReadArr());

        while (true)
        {
            if (!(firstBox.Any() && secondBox.Any()))
            {
                break;
            }

            int currentNumbersFirstBox = firstBox.Peek();
            int currentNumbersSecondBox = secondBox.Peek();
            int sum = currentNumbersFirstBox + currentNumbersFirstBox;

            if (!(sum % 2 == 0))
            {
                secondBox.Push(currentNumbersSecondBox);
                secondBox.Pop();
            }

            else
            {
                firstBox.Dequeue();
                secondBox.Pop();
            }
        }

        if (!(firstBox.Any()))
        {
            Console.WriteLine("First lootbox is empty");
        }
        else
        {
            Console.WriteLine("Second lootbox is empty");
        }
    }

   

    public static int[] ReadArr()
    {
        return Console.ReadLine()
            .Split(' ')
            .Select(int.Parse)
            .ToArray();
    }
}

