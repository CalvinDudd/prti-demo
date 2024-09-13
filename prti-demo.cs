// Importing necessary namespaces
using System;

namespace BoilerplateApp
{
    class Program
    {
        // Main method: Entry point of the program
        static void Main(string[] args)
        {
            // Display a welcome message
            Console.WriteLine("Welcome to your C# program!");

            // Optionally, you can prompt for input
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();

            // Output personalized message
            Console.WriteLine($"Hello, {name}!");

            // Keep console window open
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
