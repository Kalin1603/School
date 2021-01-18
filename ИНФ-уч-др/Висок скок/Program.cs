namespace Висок_скок
{
    using System;

    public class Program
    {
        public static void Main()
        {
            int cel = int.Parse(Console.ReadLine());
            int tochki = cel - 30;
            int skok = 0;
            int broqch = 0;
            int provaleniSkoci = 0;
            CheckPrint(cel, ref tochki, ref skok, ref broqch, ref provaleniSkoci);
        }
        private static void CheckPrint(int cel, ref int tochki, ref int skok, ref int broqch, ref int provaleniSkoci)
        {
            while (skok <= cel)
            {

                skok = int.Parse(Console.ReadLine());
                broqch++;

                if (skok > tochki && skok < cel)
                {
                    tochki += 5;
                    provaleniSkoci = 0;
                }

                else
                {
                    provaleniSkoci++;
                }

                if (provaleniSkoci == 3)
                {
                    Console.WriteLine($"Tihomir failed at {tochki} cm after {broqch} jumps.");
                    break;
                }

                else if (skok > cel)
                {
                    Console.WriteLine($"Tihomir succeeded, he jumped over {tochki} cm after {broqch} jumps.");
                    break;
                }
            }
        }
    }
}
