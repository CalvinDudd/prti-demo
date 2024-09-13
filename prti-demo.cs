using System;

namespace EnhancedApp
{
    class Program
    {
        static void Main(string[] args)
        {
            bool exit = false;

            // Main loop to keep the program running until user chooses to exit
            while (!exit)
            {
                // Displaying the main menu
                DisplayMenu();

                // Getting the user's choice
                string choice = Console.ReadLine();

                // Handling the user's choice with a switch statement
                switch (choice)
                {
                    case "1":
                        PerformCalculation();
                        break;
                    case "2":
                        DisplayCurrentDateTime();
                        break;
                    case "3":
                        Console.WriteLine("Goodbye!");
                        exit = true; // Exiting the loop and program
                        break;
                    default:
                        Console.WriteLine("Invalid choice! Please try again.");
                        break;
                }
            }
        }

        // Method to display the menu
        static void DisplayMenu()
        {
            Console.WriteLine("\n--- Main Menu ---");
            Console.WriteLine("1. Simple Calculator");
            Console.WriteLine("2. Display Current Date and Time");
            Console.WriteLine("3. Exit");
            Console.Write("Please choose an option (1-3): ");
        }

        // Method to perform a simple addition calculation
        static void PerformCalculation()
        {
            Console.WriteLine("\n--- Simple Calculator ---");

            // Prompting user for first number
            Console.Write("Enter the first number: ");
            if (double.TryParse(Console.ReadLine(), out double num1))
            {
                // Prompting user for second number
                Console.Write("Enter the second number: ");
                if (double.TryParse(Console.ReadLine(), out double num2))
                {
                    // Performing addition and displaying result
                    double result = num1 + num2;
                    Console.WriteLine($"Result: {num1} + {num2} = {result}");
                }
                else
                {
                    Console.WriteLine("Invalid input! Please enter a valid number.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input! Please enter a valid number.");
            }
        }

        // Method to display the current date and time
        static void DisplayCurrentDateTime()
        {
            Console.WriteLine("\n--- Current Date and Time ---");
            Console.WriteLine($"Current Date and Time: {DateTime.Now}");
        }
    }
}
