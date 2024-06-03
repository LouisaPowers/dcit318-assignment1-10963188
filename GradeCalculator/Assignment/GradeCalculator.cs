using System;
namespace Assignment
{
	class GradeCalculator
	{
        static void Main()
		{
            Console.Write("Enter a numerical grade between 0 and 100: ");
            string input = Console.ReadLine();
            int grade;

            // Check if the input is a valid integer
            if (int.TryParse(input, out grade))
            {
                // Check if the grade is within the valid range
                if (grade >= 0 && grade <= 100)
                {
                    char letterGrade;

                    if (grade >= 90)
                    {
                        letterGrade = 'A';
                    }
                    else if (grade >= 80)
                    {
                        letterGrade = 'B';
                    }
                    else if (grade >= 70)
                    {
                        letterGrade = 'C';
                    }
                    else if (grade >= 60)
              {
                        letterGrade = 'D';
                }
                    else
                    {
                        letterGrade = 'F';
                    }

                    Console.WriteLine("The corresponding letter grade is: " + letterGrade);
                }
                else
                {
                    Console.WriteLine("The grade must be between 0 and 100.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a numerical grade.");
            }
        }
	}
}

