using System;

namespace PracticeQuestion
{
    public class GotoLoopSearch
    {
        public static void Execute()
        {
            Console.WriteLine("=== Deep Nested Loop Search with Goto ===");
            
            // 3D array to search through
            int[,,] array3D = new int[3, 4, 5];
            int target = 42;
            bool found = false;
            int foundI = -1, foundJ = -1, foundK = -1;
            
            // Fill array with random values and place target at a specific position
            Random rand = new Random();
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    for (int k = 0; k < 5; k++)
                    {
                        array3D[i, j, k] = rand.Next(1, 100);
                    }
                }
            }
            
            // Place target value at position [1, 2, 3]
            array3D[1, 2, 3] = target;
            
            Console.WriteLine("Searching for target value: " + target);
            Console.WriteLine("Array contents:");
            
            // Display the array
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"Layer {i}:");
                for (int j = 0; j < 4; j++)
                {
                    for (int k = 0; k < 5; k++)
                    {
                        Console.Write($"{array3D[i, j, k],4} ");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
            
            // Deep nested loop search with goto
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    for (int k = 0; k < 5; k++)
                    {
                        Console.WriteLine($"Checking position [{i}, {j}, {k}]: {array3D[i, j, k]}");
                        
                        if (array3D[i, j, k] == target)
                        {
                            found = true;
                            foundI = i;
                            foundJ = j;
                            foundK = k;
                            goto FoundTarget; // Exit all nested loops instantly
                        }
                    }
                }
            }
            
            FoundTarget:
            if (found)
            {
                Console.WriteLine($"\n✓ Target {target} found at position [{foundI}, {foundJ}, {foundK}]!");
            }
            else
            {
                Console.WriteLine($"\n✗ Target {target} not found in the array.");
            }
            
            Console.WriteLine("\nThis demonstrates how 'goto' can exit multiple nested loops instantly");
            Console.WriteLine("when a search condition is met, avoiding the need for multiple break statements.");
        }
    }
}