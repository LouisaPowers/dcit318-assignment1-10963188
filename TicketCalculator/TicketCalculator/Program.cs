using System;

class Program
{
    static void Main()
    {
     Console.Write("Enter your age: ");
        string input = Console.ReadLine();
        int age;

        // Check if the input is a valid integer
    if (int.TryParse(input, out age))
        {
            int ticketPrice;

            // Determine the ticket price based on age
            if (age <= 12 || age >= 65)
            {
                ticketPrice = 7; // Discounted price for children and senior citizens
            }
            else
            {
                ticketPrice = 10; // Regular price
            }

            Console.WriteLine("The ticket price is: GHC" + ticketPrice);
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid age.");
        }
    }
}
