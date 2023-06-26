using System;

namespace marks_order
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create an array to store the test marks
            int[] testMarks = new int[8];

            // Prompt the user to enter the test marks
            Console.WriteLine("Enter the test marks:");

            // Read the test marks from the user
            for (int i = 0; i < 8; i++)
            {
                Console.Write($"Test {i + 1}: ");
                testMarks[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine();

            // Display the test marks in the order they were entered
            Console.WriteLine("Test marks in the order they were entered:");
            for (int i = 0; i < 8; i++)
            {
                Console.WriteLine($"Test {i + 1}: {testMarks[i]}");
            }

            Console.WriteLine();

            // Sort the test marks in ascending order
            Array.Sort(testMarks);

            // Display the test marks from smallest to largest
            Console.WriteLine("Test marks from smallest to largest:");
            for (int i = 0; i < 8; i++)
            {
                Console.WriteLine($"Test {i + 1}: {testMarks[i]}");
            }

            Console.WriteLine();

            // Display the test marks from largest to smallest
            Console.WriteLine("Test marks from largest to smallest:");
            for (int i = 7; i >= 0; i--)
            {
                Console.WriteLine($"Test {8 - i}: {testMarks[i]}");
            }

            Console.ReadLine();
        }
    }
}
