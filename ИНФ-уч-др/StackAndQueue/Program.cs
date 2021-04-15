using StackAndQueue;
using System;


public class Program
{
    public static void Main()
    {
        //MyQueue<int> numbers = new MyQueue<int>();
        //numbers.Enqueue(1);
        //numbers.Enqueue(2);
        //numbers.Enqueue(3);
        //numbers.Enqueue(4);
        //numbers.Enqueue(5);
        //numbers.Enqueue(6);

        //while (numbers.Count > 0)
        //{
        //    int num = numbers.Dequeue();
        //    Console.WriteLine(num);
        //    //1, 2, 3, 4, 5, 6  
        //}

        MyStack<int> numbers = new MyStack<int>();
        MyStack<string> words = new MyStack<string>();

        words.Push("C#");
        words.Push(".Net");
        words.Push("PHP");
        words.Push("JS");
        Console.WriteLine(words.Pop());
        Console.WriteLine(words.Pop());
        Console.WriteLine(words.Count);
    }
}

