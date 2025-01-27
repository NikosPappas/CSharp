using System;

public class SimpleCalculator
{
    public static void Main(string[] args)
    {
        bool continueCalculating = true;
        while (continueCalculating)
        {
            // Input
            double num1 = GetNumber("Enter the first number: ");
            char operation = GetOperation("Enter the operation (+, -, *, /): ");
            double num2 = GetNumber("Enter the second number: ");

            // Calculation
            double result = PerformCalculation(num1, operation, num2);


            // Output
            if (!double.IsNaN(result)) // Check if the result was valid
            {
                Console.WriteLine($"Result: {result}");
            }

            // Continue or Exit
            Console.Write("Do you want to perform another calculation? (y/n): ");
            string continueInput = Console.ReadLine().ToLower();
            if (continueInput != "y")
            {
                continueCalculating = false;
            }
        }
        Console.WriteLine("Calculator closed.");
    }

    // Helper function to get a valid number from user
    static double GetNumber(string prompt)
    {
        double number;
        bool isValid = false;
        do
        {
            Console.Write(prompt);
            string input = Console.ReadLine();
            if (double.TryParse(input, out number))
            {
                isValid = true;
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }
        } while (!isValid);
        return number;
    }
    
    // Helper function to get a valid operator from user
    static char GetOperation(string prompt)
    {
          char operation=' ';
          bool isValid = false;
          do
          {
              Console.Write(prompt);
              string input = Console.ReadLine();
              if (input.Length == 1 && (input[0] == '+' || input[0] == '-' || input[0] == '*' || input[0] == '/'))
              {
                operation = input[0];
                isValid = true;
              } else {
                Console.WriteLine("Invalid operation. Please enter one of: +, -, *, /");
              }
          } while (!isValid);

          return operation;
    }
    

    // Helper function to perform the calculation
    static double PerformCalculation(double num1, char operation, double num2)
    {
        double result = double.NaN; // Default value for "Not a Number" if there's an issue
        switch (operation)
        {
            case '+':
                result = num1 + num2;
                break;
            case '-':
                result = num1 - num2;
                break;
            case '*':
                result = num1 * num2;
                break;
            case '/':
                if (num2 == 0)
                {
                    Console.WriteLine("Error: Cannot divide by zero.");
                }
                else
                {
                    result = num1 / num2;
                }
                break;
            default:
                Console.WriteLine("Invalid operator.");
                break;
        }
        return result;
    }
}