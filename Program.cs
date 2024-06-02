/* using System;

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
 */
 using System;

namespace MovieTicketCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Prompt the user to enter their age
            Console.Write("Enter your age: ");
            string input = Console.ReadLine();
            int age;

            // Validate the input and convert it to an integer
            while (!int.TryParse(input, out age) || age < 0)
            {
                Console.WriteLine("Invalid input. Please enter a valid age.");
                Console.Write("Enter your age: ");
                input = Console.ReadLine();
            }

            // Determine the ticket price based on the age
            int ticketPrice = CalculateTicketPrice(age);

            // Display the ticket price
            Console.WriteLine($"The ticket price is GHC{ticketPrice}.");
        }

        static int CalculateTicketPrice(int age)
        {
            if (age <= 12 || age >= 65)
            {
                return 7; // Discounted price for children and senior citizens
            }
            else
            {
                return 10; // Regular price
            }
        }
    }
}
