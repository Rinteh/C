using System;

namespace TaxApp
{
    internal class TaxApps
    {
        static void Main(string[] args)
        { const Double cc = 0.06;
            Console.WriteLine("Enter item price for tax to be calculated:\n");
            Double Price = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("*********************************************");
            Double tx = Price * cc;

            Double inc = tx + Price;
                        Console.WriteLine("Tax is at 6%\n");
            Console.WriteLine("*********************************************\n");
            Console.WriteLine("The item price with tax included is: "+ inc);
        }
    }
}
