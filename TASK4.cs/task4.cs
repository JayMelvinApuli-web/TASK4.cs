using System;

class ArithmeticCalculator
{
    // Method to perform addition
    static double Add(double a, double b)
    {
        return a + b;
    }

    // Method to perform subtraction
    static double Subtract(double a, double b)
    {
        return a - b;
    }

    // Method to perform multiplication
    static double Multiply(double a, double b)
    {
        return a * b;
    }

    // Method to perform division
    static double Divide(double a, double b)
    {
        if (b == 0)
        {
            Console.WriteLine("Error: Division by zero is not allowed.");
            return double.NaN; // Return "Not a Number" for division by zero
        }
        return a / b;
    }

    static void Main()
    {
        char continueChoice;
        
        // Loop to allow continuous calculation
        do
        {
            // Displaying the menu
            Console.WriteLine("Press any following key to perform an arithmetic operation:");
            Console.WriteLine("1 - Addition");
            Console.WriteLine("2 - Subtraction");
            Console.WriteLine("3 - Multiplication");
            Console.WriteLine("4 - Division");
            Console.Write("Choose an operation (1-4): ");
            
            int operationChoice = int.Parse(Console.ReadLine());

            // Get values from the user
            Console.Write("Enter Value 1: ");
            double value1 = double.Parse(Console.ReadLine());

            Console.Write("Enter Value 2: ");
            double value2 = double.Parse(Console.ReadLine());

            double result = 0;

            // Switch case to handle different operations
            switch (operationChoice)
            {
                case 1: // Addition
                    result = Add(value1, value2);
                    Console.WriteLine($"{value1} + {value2} = {result}");
                    break;
                case 2: // Subtraction
                    result = Subtract(value1, value2);
                    Console.WriteLine($"{value1} - {value2} = {result}");
                    break;
                case 3: // Multiplication
                    result = Multiply(value1, value2);
                    Console.WriteLine($"{value1} * {value2} = {result}");
                    break;
                case 4: // Division
                    result = Divide(value1, value2);
                    if (!double.IsNaN(result)) // Check if division result is valid
                        Console.WriteLine($"{value1} / {value2} = {result}");
                    break;
                default:
                    Console.WriteLine("Invalid option. Please choose a valid operation (1-4).");
                    break;
            }

            // Ask user if they want to continue or exit
            Console.Write("Do you want to continue again (Y/N)? ");
            continueChoice = char.ToUpper(Console.ReadKey().KeyChar);
            Console.WriteLine(); // Move to the next line after user input
        }
        while (continueChoice == 'Y');
        
        // Exit message
        Console.WriteLine("Thank you for using the calculator!");
    }
}
