namespace CinemaTickets
{
    using System;

    public class Program
    {
        public static void Main()
        {
            int totalTickets = 0;
            int kidTickets = 0;
            int standardTickets = 0;
            int studentTickets = 0;

            while (true)
            {
                Console.Write("Movie: ");
                string movie = Console.ReadLine();

                if (movie == "Finish")
                {
                    break;
                }

                Console.Write("Seats: ");
                int seats = int.Parse(Console.ReadLine());
                int usedSeats = 0;

                while (seats > usedSeats)
                {
                    Console.Write("Ticket type: ");
                    string ticket = Console.ReadLine();
                    

                    if (ticket == "End")
                    {
                        break;
                    }
                    usedSeats++;
                    totalTickets++;

                    switch (ticket)
                    {
                        case "standard":
                            standardTickets++;
                            break;
                        case "kid":
                            kidTickets++;
                            break;
                        case "student":
                            studentTickets++;
                            break;
                        default:
                            break;
                    }
                }
                Console.WriteLine($"{movie} - {usedSeats/(double)seats*100:f2}% full.");
            }
            Console.WriteLine($"Total tickets: {totalTickets:f2}");
            Console.WriteLine($"{studentTickets/(double)totalTickets*100:f2}% studenttickets.");
            Console.WriteLine($"{standardTickets/(double)totalTickets*100:f2}% standardtickets.");
            Console.WriteLine($"{kidTickets/(double)totalTickets*100:f2}% kidstickets.");
        }
    }
}
