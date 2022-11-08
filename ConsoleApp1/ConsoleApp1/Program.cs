using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //NR Added list of available conversions
            Console.WriteLine("The available conversions are:");
            Console.WriteLine("kg <=> lbs");
            Console.WriteLine("cm <=> in");
            Console.WriteLine("oz <=> ml");

            Console.WriteLine("Please enter your value");
            int value = Int16.Parse(Console.ReadLine());

            Console.WriteLine("Please enter its units.");
            string unit = Console.ReadLine();

            Console.WriteLine("Please enter the unit you would like it converted to.");
            string newUnit = Console.ReadLine();

            if (unit == "kg" && newUnit == "lbs")
            {
                Console.WriteLine((double)value * 2.2 + " lbs");
            }

            if (unit == "lbs" && newUnit == "kg")
            {
                Console.WriteLine((double)value * 0.45359237 + " kg");
            }

            if (unit == "cm" && newUnit == "in")
            {
                Console.WriteLine((double)value / 2.54 + " in");
            }

            if (unit == "in" && newUnit == "cm")
            {
                Console.WriteLine((double)value * 2.54 + " cm");
            }

            if (unit == "lbs" && newUnit == "oz")
            {
                Console.WriteLine((double)value * 16 + " oz");
            }

            if (unit == "oz" && newUnit == "lbs")
            {
                Console.WriteLine((double)value / 16 + " lbs");

            }

            if (unit == "cm" && newUnit == "mm")
            {
                Console.WriteLine((double)value * 10 + " mm");
            }

            if (unit == "mm" && newUnit == "cm")
            {
                Console.WriteLine((double)value / 10 + " cm");
            }
            //NR: Added ML => OZ
            if (unit == "oz" && newUnit == "ml")
            {
                Console.WriteLine("{0:F2} {1}", value * 29.574, newUnit);
            }

            if (unit == "ml" && newUnit == "oz")
            {
                Console.WriteLine("{0:F2} {1}", value / 29.574 , newUnit);
            }


        }
    }
}
