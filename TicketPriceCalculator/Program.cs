using System;

namespace TicketPriceCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            const int regularPrice = 10;
            const int discountedPrice = 7;

            Console.WriteLine("Enter your age:");
            int age = int.Parse(Console.ReadLine());

            if (age <= 12 || age >= 65)
            {
                Console.WriteLine($"Ticket Price: GHC{discountedPrice}");
            }
            else
            {
                Console.WriteLine($"Ticket Price: GHC{regularPrice}");
            }
        }
    }
}

