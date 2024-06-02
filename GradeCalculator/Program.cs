using System;

namespace GradeCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a numerical grade between 0 and 100:");
            string input = Console.ReadLine();

            if (int.TryParse(input, out int grade))
            {
                if (grade >= 90)
                {
                    Console.WriteLine("Your letter grade is: A");
                }
                else if (grade >= 80)
                {
                    Console.WriteLine("Your letter grade is: B");
                }
                else if (grade >= 70)
                {
                    Console.WriteLine("Your letter grade is: C");
                }
                else if (grade >= 60)
                {
                    Console.WriteLine("Your letter grade is: D");
                }
                else
                {
                    Console.WriteLine("Your letter grade is: F");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a number between 0 and 100.");
            }
        }
    }
}