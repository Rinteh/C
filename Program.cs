using System;

namespace max
{
    internal class Program
    {

        static int FindMax(int num1, int num2)
        {
            // Compare the two numbers and return the maximum
            if (num1 > num2)
            {
                return num1;
            }
            else
            {
                return num2;
            }
        }
            static void Main(string[] args)
            {
                // Get user input for the two numbers
                Console.Write("Enter the first number: ");
                int num1 = int.Parse(Console.ReadLine());

                Console.Write("Enter the second number: ");
                int num2 = int.Parse(Console.ReadLine());

                // Call the FindMax method to determine the maximum value
                int max_value = FindMax(num1, num2);

                // Display the result
                Console.WriteLine("The maximum value is: " + max_value);
            }
        }
    
}
