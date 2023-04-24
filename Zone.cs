using System;

namespace Question_1
{
    internal class Program
    {
        enum ZoneName
        {
            SCHOOL = 1, CITY, HIGHWAY
        }
        enum SpeedLimit
        {
            SCHOOL_ZONE_SPEED = 20,
            CITY_STREET_SPEED = 30,
            HIGHWAY_SPEED = 55
        }


        static void Main(string[] args)
        {
            ZoneName zone;
            SpeedLimit sl;
            int iZone;

            System.Console.WriteLine("*********************************");
            System.Console.WriteLine("Please enter a zone number");
            System.Console.WriteLine("1.School");
            System.Console.WriteLine("2.City");
            System.Console.WriteLine("3.Highway");
            System.Console.WriteLine();
            System.Console.WriteLine("*********************************");

            iZone = Convert.ToInt32(System.Console.ReadLine());

            System.Console.WriteLine();
            Console.WriteLine("Please enter your current speed");
            int currentSpeed = Convert.ToInt16(System.Console.ReadLine());

            zone = (ZoneName)iZone;

            switch (zone)
            {
                case ZoneName.SCHOOL:
                    if (currentSpeed > (int)SpeedLimit.SCHOOL_ZONE_SPEED)//i have errors by my if statements 
                    {
                        Console.WriteLine("Slow down and maintain the speed limit of 20 ine the School Zone");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Thank you for maintaining the speed limit in the School Zone ");
                    }
                    break;
                case ZoneName.CITY:
                    if (currentSpeed > (int)SpeedLimit.CITY_STREET_SPEED)
                    {
                        Console.WriteLine("Slow down and maintain the speed limit of 30 in the City Zone");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Thank you for maintaining the speed limit in the City Zone ");
                    }
                    break;
                case ZoneName.HIGHWAY:
                    if (currentSpeed > (int)SpeedLimit.HIGHWAY_SPEED)
                    {
                        Console.WriteLine("Slow down and maintain the speed limit of 55 on the Highway Zone");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Thank you for maintaining the speed limit in the Highway Zone ");
                    }
                    break;

                    System.Console.Read();
            }
        }
    }
}
