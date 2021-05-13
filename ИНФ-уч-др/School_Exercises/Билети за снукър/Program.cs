namespace Билети_за_снукър
{
    using System;
    using System.Linq;
    using System.Text;

    public class Program
    {
        public static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("Stage: ");
            string stage = Console.ReadLine();
            Console.Write("Ticket tpye: ");
            string type = Console.ReadLine();
            Console.Write("Ticket number: ");
            int ticketNum = int.Parse(Console.ReadLine());
            Console.Write("Take photo: ");
            char photoTrophy = Console.ReadLine().First();

            decimal price = 0.0m;
            price = SelectPrice(stage, type, price);

            price *= ticketNum;
            
            if (price >  4000)
            {
                price *= 0.75m;
            }
            else if (price > 2500)
            {
                price *= 0.9m;
                if (photoTrophy == Yes)
                {
                    price += (40 * ticketNum);
                }
            }
            else
            {
                if (photoTrophy == Yes)
                {
                    price += (40 * ticketNum);
                }
            }
            
            Console.WriteLine($"{price:f2}");
        }

        private static decimal SelectPrice(string stage, string type, decimal price)
        {
            switch (stage)
            {
                case QuarterFinal:
                    switch (type)
                    {
                        case Standard:
                            price = StandardQuarterPrice;
                            break;
                        case Premium:
                            price = PremiumQuarterPrice;
                            break;
                        case VIP:
                            price = VIPQuarterPrice;
                            break;
                        default:
                            break;
                    }
                    break;
                case SemiFinal:
                    switch (type)
                    {
                        case Standard:
                            price = StandardQuarterPrice;
                            break;
                        case Premium:
                            price = PremiumSemiPrice;
                            break;
                        case VIP:
                            price = VIPSemiPrice;
                            break;
                        default:
                            break;
                    }
                    break;
                case Final:
                    switch (type)
                    {
                        case Standard:
                            price = StandardFinalPrice;
                            break;
                        case Premium:
                            price = PremiumFinalPrice;
                            break;
                        case VIP:
                            price = VIPFinalPrice;
                            break;
                        default:
                            break;
                    }
                    break;
                default:
                    break;
            }

            return price;
        }

        const string QuarterFinal = "Quarter final";
        const string SemiFinal = "Semi final";
        const string Final = "Final";
        const string Standard = "Standard";
        const string Premium = "Premium";
        const string VIP = "VIP";
        const char Yes = 'Y';
        const char No = 'N';
        const decimal StandardQuarterPrice = 55.5m;
        const decimal StandardSemiPrice = 75.88m;
        const decimal StandardFinalPrice = 110.10m;
        const decimal PremiumQuarterPrice = 105.20m;
        const decimal PremiumSemiPrice = 125.22m;
        const decimal PremiumFinalPrice = 160.66m;
        const decimal VIPQuarterPrice = 118.90m;
        const decimal VIPSemiPrice = 300.40m;
        const decimal VIPFinalPrice = 400m;

    }
}
