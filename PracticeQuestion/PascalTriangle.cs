using System;

namespace PracticeQuestion
{
    public class PascalTriangle
    {
        public static void Execute()
        {
            Console.WriteLine("=== Pascal's Triangle using Nested Loops ===");
            
            Console.Write("Enter the number of rows for Pascal's Triangle: ");
            string input = Console.ReadLine();
            
            if (!int.TryParse(input, out int n) || n <= 0)
            {
                Console.WriteLine("Please enter a valid positive number.");
                return;
            }
            
            PrintPascalTriangle(n);
        }
        
        private static void PrintPascalTriangle(int n)
        {
            Console.WriteLine($"\nPascal's Triangle with {n} rows:\n");
            
            // Outer loop for rows
            for (int i = 0; i < n; i++)
            {
                // Print spaces for alignment
                for (int space = 0; space < n - i - 1; space++)
                {
                    Console.Write("   ");
                }
                
                // Inner loop for columns in each row
                for (int j = 0; j <= i; j++)
                {
                    int value = CalculateBinomialCoefficient(i, j);
                    Console.Write($"{value,6}");
                }
                
                Console.WriteLine(); // Move to next row
            }
            
            Console.WriteLine("\nExplanation:");
            Console.WriteLine("- Each number is the sum of the two numbers above it");
            Console.WriteLine("- The edges are always 1");
            Console.WriteLine("- Row n has (n+1) elements");
            Console.WriteLine("- Each element at position (i,j) = C(i,j) = i! / (j! * (i-j)!)");
        }
        
        // Calculate binomial coefficient C(n, k) = n! / (k! * (n-k)!)
        private static int CalculateBinomialCoefficient(int n, int k)
        {
            if (k == 0 || k == n)
                return 1;
            
            int result = 1;
            
            // Use the property C(n,k) = C(n,n-k) to minimize calculations
            if (k > n - k)
                k = n - k;
            
            // Calculate C(n,k) = n * (n-1) * ... * (n-k+1) / (k * (k-1) * ... * 1)
            for (int i = 0; i < k; i++)
            {
                result = result * (n - i) / (i + 1);
            }
            
            return result;
        }
        
        // Alternative method using dynamic programming approach
        public static void ExecuteWithDP()
        {
            Console.WriteLine("=== Pascal's Triangle using Dynamic Programming ===");
            
            Console.Write("Enter the number of rows: ");
            string input = Console.ReadLine();
            
            if (!int.TryParse(input, out int n) || n <= 0)
            {
                Console.WriteLine("Please enter a valid positive number.");
                return;
            }
            
            PrintPascalTriangleDP(n);
        }
        
        private static void PrintPascalTriangleDP(int n)
        {
            Console.WriteLine($"\nPascal's Triangle (DP approach) with {n} rows:\n");
            
            // Create a 2D array to store Pascal's triangle
            int[][] triangle = new int[n][];
            
            // Initialize and fill the triangle using nested loops
            for (int i = 0; i < n; i++)
            {
                triangle[i] = new int[i + 1];
                
                // First and last elements of each row are 1
                triangle[i][0] = 1;
                triangle[i][i] = 1;
                
                // Fill the middle elements
                for (int j = 1; j < i; j++)
                {
                    triangle[i][j] = triangle[i - 1][j - 1] + triangle[i - 1][j];
                }
            }
            
            // Print the triangle with proper formatting
            for (int i = 0; i < n; i++)
            {
                // Print spaces for alignment
                for (int space = 0; space < n - i - 1; space++)
                {
                    Console.Write("   ");
                }
                
                // Print the row elements
                for (int j = 0; j <= i; j++)
                {
                    Console.Write($"{triangle[i][j],6}");
                }
                
                Console.WriteLine();
            }
        }
    }
}