using System;

namespace SwitchMark
{
    internal class SwitchMarks
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your grade: ");
            int grade = Convert.ToInt32(Console.ReadLine());

            switch (grade)
            {
                case int n when (n >= 74 && n <= 100):
                    Console.WriteLine("Your grade is: A ");
                    break;
                case int n when (n > 59 && n < 75):
                    Console.WriteLine("Your grade is: B");
                    break;
                case int n when (n > 49 && n < 60):
                    Console.WriteLine("Your grade is: C");
                    break;
                case int n when (n > 39 && n < 50):
                    Console.WriteLine("Your grade is: D");
                    break;
                case int n when (n < 40):
                    Console.WriteLine("Your grade is: F");
                    break;
                default:
                    Console.WriteLine("You have made incorrect input. ");
                    break ;
            }
        }
    }
}
