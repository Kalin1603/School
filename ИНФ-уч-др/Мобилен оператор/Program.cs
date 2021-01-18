namespace Мобилен_оператор
{
    using System;

    public class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Contract: ");
            string contract = Console.ReadLine();
            Console.Write($"Contract type: ");
            string typeContract = Console.ReadLine();
            Console.Write("Add mobile interner: ");
            string addMobileNet = Console.ReadLine();
            Console.Write("Number of months to pay: ");
            int numberOfMonthsPay = int.Parse(Console.ReadLine());

            decimal price = 0.0m;
            price = SelectPrice(contract, typeContract, price);

            if (addMobileNet == Yes && contract == ContractOne)
            {
                if (price <= 10.00m)
                {
                    price = price + 5.50m;
                    Console.WriteLine($"{price * numberOfMonthsPay:f2} лв.");
                }

                else if (price <= 30.00m)
                {
                    price = price + 4.35m;
                    Console.WriteLine($"{price * numberOfMonthsPay:f2} лв.");
                }

                else if (price > 30.00m)
                {
                    price = price + 3.85m;
                    Console.WriteLine($"{price * numberOfMonthsPay:f2} лв.");
                }
            }
            if (contract == ContractTwo && addMobileNet == Yes)
            {
                if (price <= 10.00m)
                {
                    price = price + 5.50m ;
                    price = (price * numberOfMonthsPay) - (price * 0.0375m * numberOfMonthsPay);
                    Console.WriteLine($"{price:f2} лв.");
                    
                }

                else if (price <= 30.00m)
                {
                    price = price + 4.35m ;
                    price = (price * numberOfMonthsPay) - (price * 0.0375m * numberOfMonthsPay);
                    Console.WriteLine($"{price:f2} лв.");
                }

                else if (price > 30.00m)
                {
                    price = price + 3.85m ;
                    price = (price * numberOfMonthsPay) - (price * 0.0375m * numberOfMonthsPay);
                    Console.WriteLine($"{price:f2} лв.");
                }
            }

            if (contract == ContractTwo && addMobileNet == No)
            {               
                price = (price * numberOfMonthsPay) - (price * 0.0375m * numberOfMonthsPay);
                Console.WriteLine($"{price:f2} лв.");
            }
        }

        private static decimal SelectPrice(string contract, string typeContract, decimal price)
        {
            switch (contract)
            {
                case ContractOne:
                    switch (typeContract)
                    {
                        case Small:
                            price = SmallOneYear;
                            break;
                        case Middle:
                            price = MiddleOneYear;
                            break;
                        case Large:
                            price = LargeOneYear;
                            break;
                        case ExtraLarge:
                            price = ExtraLargeOneYear;
                            break;
                        default:
                            break;
                    }
                    break;
                case ContractTwo:
                    switch (typeContract)
                    {
                        case Small:
                            price = SmallTwoYears;
                            break;
                        case Middle:
                            price = MiddleTwoYears;
                            break;
                        case Large:
                            price = LargeTwoYears;
                            break;
                        case ExtraLarge:
                            price = ExtraLargeTwoYears;
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

        const string ContractOne = "one";
        const string ContractTwo = "two";
        const string Small = "Small";
        const string Middle = "Middle";
        const string Large = "Large";
        const string ExtraLarge = "ExtraLarge";
        const string Yes = "yes";
        const string No = "no";
        const decimal SmallOneYear = 9.98m;
        const decimal SmallTwoYears = 8.58m;
        const decimal MiddleOneYear = 18.99m;
        const decimal MiddleTwoYears = 17.09m;
        const decimal LargeOneYear = 25.98m;
        const decimal LargeTwoYears = 23.59m;
        const decimal ExtraLargeOneYear = 35.99m;
        const decimal ExtraLargeTwoYears = 31.79m;


    }
}
