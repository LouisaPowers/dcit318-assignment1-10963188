using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter the length of side 1: ");
        string input1 = Console.ReadLine();
        Console.Write("Enter the length of side 2: ");
        string input2 = Console.ReadLine();
        Console.Write("Enter the length of side 3: ");
        string input3 = Console.ReadLine();

        // Try to parse all inputs as integers
        if (int.TryParse(input1, out int side1) && int.TryParse(input2, out int side2) && int.TryParse(input3, out int side3))
        {
            // Check if all sides are positive
            if (side1 > 0 && side2 > 0 && side3 > 0)
            {
                // Determine the type of triangle
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
                Console.WriteLine("All sides must be positive numbers.");
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter valid numbers for all sides.");
        }
    }
}
