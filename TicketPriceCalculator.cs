using System;

class TicketPriceCalculator
{
    static void Main()
    {
        Console.Write("Enter your age: ");

        bool isValid = int.TryParse(Console.ReadLine(), out int age);

        if (!isValid || age < 0)
        {
            Console.WriteLine("Invalid input. Please enter a valid non-negative age.");
        }
        else
        {
            double price;

            if (age >= 65 || age <= 12)
                price = 7.00; // Discounted price for seniors and children
            else
                price = 10.00; // Regular price

            Console.WriteLine($"Your ticket price is: GHC{price:F2}");
        }

        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }
}
