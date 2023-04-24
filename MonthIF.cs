using System;
using System.Globalization;

namespace MonthEnum
{
    internal class MonthIF
    {

        static void Main(string[] args)
        {

            int MonNum;
            Console.WriteLine("Enter a Number from 1 to 12: ");
            Console.WriteLine("*********************************");
            MonNum = Convert.ToInt32(Console.ReadLine());



            if (MonNum == 1)
            {
                Console.WriteLine("January");
            }
            else if (MonNum == 2)
            {
                Console.WriteLine("February");
            }
            else if (MonNum == 3)
            {
                Console.WriteLine("March");

            }
        }
    }
}
