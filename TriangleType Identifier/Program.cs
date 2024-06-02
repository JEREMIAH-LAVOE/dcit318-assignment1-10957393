using System;

namespace TriangleClassifier
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the lengths of the three sides of the triangle:");

            Console.Write("Side 1: ");
            string side1Input = Console.ReadLine();

            Console.Write("Side 2: ");
            string side2Input = Console.ReadLine();

            Console.Write("Side 3: ");
            string side3Input = Console.ReadLine();

            if (double.TryParse(side1Input, out double side1) &&
                double.TryParse(side2Input, out double side2) &&
                double.TryParse(side3Input, out double side3))
            {
                if (side1 == side2 && side2 == side3)
                {
                    Console.WriteLine("The triangle is Equilateral.");
                }
                else if (side1 == side2 || side1 == side3 || side2 == side3)
                {
                    Console.WriteLine("The triangle is Isosceles.");
                }
                else
                {
                    Console.WriteLine("The triangle is Scalene.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter valid numbers for the side lengths.");
            }
        }
    }
}