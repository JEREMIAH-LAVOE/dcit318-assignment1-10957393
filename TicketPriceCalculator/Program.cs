using System;

namespace MovieTicketCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your age:");
            string input = Console.ReadLine();

            if (int.TryParse(input, out int age))
            {
                if (age >= 65 || age <= 12)
                {
                    Console.WriteLine("Your ticket price is GHC7.");
                }
                else
                {
                    Console.WriteLine("Your ticket price is GHC10.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a number.");
            }
        }
    }
}