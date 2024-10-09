using System;

class ShippingQuote
{
    static void Main()
    {
        // Display the welcome message.
        Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

        // Prompt the user for the package weight.
        Console.Write("Please enter the package weight: ");
        double weight = Convert.ToDouble(Console.ReadLine());

        // Check if the weight is greater than 50. If it is, display an error message and end the program.
        if (weight > 50)
        {
            Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
            return; // End the program here.
        }

        // Prompt the user for the package width.
        Console.Write("Please enter the package width: ");
        double width = Convert.ToDouble(Console.ReadLine());

        // Prompt the user for the package height.
        Console.Write("Please enter the package height: ");
        double height = Convert.ToDouble(Console.ReadLine());

        // Prompt the user for the package length.
        Console.Write("Please enter the package length: ");
        double length = Convert.ToDouble(Console.ReadLine());

        // Check if the sum of the dimensions is greater than 50. If it is, display an error message and end the program.
        if (width + height + length > 50)
        {
            Console.WriteLine("Package too big to be shipped via Package Express.");
            return; // End the program here.
        }

        // Multiply the dimensions together and then multiply by the weight.
        double volume = width * height * length;
        double quote = (volume * weight) / 100;

        // Display the shipping quote to the user.
        Console.WriteLine("Your estimated total for shipping this package is: $" + quote.ToString("0.00"));
        Console.WriteLine("Thank you!");
    }
}