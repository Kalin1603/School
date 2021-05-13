using System;
using System.Security.Cryptography;
using System.Text;

namespace Methods
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine($"SumRandom result: {SumRandom(3)}");
            Console.WriteLine($"ProductSumRandom result: {ProductSumRandom(7,11)}");
            Console.WriteLine(HashPass("1234"));
        }

        public static int SumRandom(int num)
        {
            Random r = new Random();
            int rNum = r.Next(1, 1000);
            int result = num + rNum;
            return result;
        }

        static int ProductSumRandom(int fNum, int sNum)
        {
            int first = SumRandom(fNum);
            int second = SumRandom(sNum);
            int result = first * second;
            return result;
        }

        static string HashPass(string userPass)
        {
            SHA512 shaM = new SHA512Managed();
            var data = Encoding.UTF8.GetBytes(userPass);
            var hash = shaM.ComputeHash(data);
            string result = Encoding.UTF8.GetString(hash);
            return result;
        }
    }
}
