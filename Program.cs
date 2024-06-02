using System;

namespace GradeCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Prompt the user to enter a numerical grade
            Console.Write("Enter a numerical grade between 0 and 100: ");
            string input = Console.ReadLine();
            int grade;

            // Validate the input and convert it to an integer
            while (!int.TryParse(input, out grade) || grade < 0 || grade > 100)
            {
                Console.WriteLine("Invalid input. Please enter a numerical grade between 0 and 100.");
                Console.Write("Enter a numerical grade between 0 and 100: ");
                input = Console.ReadLine();
            }

            // Determine the corresponding letter grade
            string letterGrade = GetLetterGrade(grade);

            // Display the letter grade
            Console.WriteLine($"The letter grade for {grade} is {letterGrade}.");
        }

        static string GetLetterGrade(int grade)
        {
            if (grade >= 90)
            {
                return "A";
            }
            else if (grade >= 80)
            {
                return "B";
            }
            else if (grade >= 70)
            {
                return "C";
            }
            else if (grade >= 60)
            {
                return "D";
            }
            else
            {
                return "F";
            }
        }
    }
}
