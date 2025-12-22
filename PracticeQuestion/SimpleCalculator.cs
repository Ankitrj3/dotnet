/// <summary>
/// SimpleCalculator - Performs basic arithmetic operations using switch statement
/// Supports addition (+), subtraction (-), multiplication (*), and division (/)
/// Includes error handling for division by zero and invalid operators
/// </summary>
class SimpleCalculator
{
    /// <summary>
    /// Performs calculation based on two numbers and an operator
    /// </summary>
    /// <param name="num1">First number</param>
    /// <param name="num2">Second number</param>
    /// <param name="operation">Operator (+, -, *, /)</param>
    public void Calculate(double num1, double num2, char operation)
    {
        double result = 0;
        bool validOperation = true;

        // Use switch statement to perform operation based on operator
        switch (operation)
        {
            case '+':
                result = num1 + num2;
                Console.WriteLine($"{num1} + {num2} = {result}");
                break;

            case '-':
                result = num1 - num2;
                Console.WriteLine($"{num1} - {num2} = {result}");
                break;

            case '*':
                result = num1 * num2;
                Console.WriteLine($"{num1} × {num2} = {result}");
                break;

            case '/':
                // Check for division by zero
                if (num2 != 0)
                {
                    result = num1 / num2;
                    Console.WriteLine($"{num1} ÷ {num2} = {result:F4}");
                }
                else
                {
                    Console.WriteLine("Error: Division by zero is not allowed");
                    validOperation = false;
                }
                break;

            default:
                Console.WriteLine($"Error: Invalid operator '{operation}'");
                Console.WriteLine("Supported operations: +, -, *, /");
                validOperation = false;
                break;
        }

        // Display additional information for valid operations
        if (validOperation && operation != '/')
        {
            Console.WriteLine($"Result: {result}");
        }
    }

    /// <summary>
    /// Interactive calculator that takes input from user
    /// </summary>
    public void RunInteractiveCalculator()
    {
        try
        {
            Console.WriteLine("=== Simple Calculator ===");
            Console.Write("Enter first number: ");
            double num1 = double.Parse(Console.ReadLine());

            Console.Write("Enter operator (+, -, *, /): ");
            char operation = Console.ReadLine()[0];

            Console.Write("Enter second number: ");
            double num2 = double.Parse(Console.ReadLine());

            Calculate(num1, num2, operation);
        }
        catch (Exception e)
        {
            Console.WriteLine($"Error: Invalid input - {e.Message}");
        }
    }
}