namespace Magazine
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Program
    {
        public static void Main()
        {
            SortedDictionary<string,int> store = new SortedDictionary<string, int>();
            string product = Console.ReadLine();
            double price = double.Parse(Console.ReadLine());
            int productNumber = int.Parse(Console.ReadLine());

            string cmd = Console.ReadLine();
            while (true)
            {
                if (cmd=="КРАЙ")
                {
                    break;
                }

               
            }
        }
    }
}
