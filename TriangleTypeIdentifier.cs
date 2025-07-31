using System;

class TriangleTypeIdentifier
{
    static void Main()
    {
        Console.Write("Enter length of side 1: ");
        bool isValid1 = double.TryParse(Console.ReadLine(), out double side1);

        Console.Write("Enter length of side 2: ");
        bool isValid2 = double.TryParse(Console.ReadLine(), out double side2);

        Console.Write("Enter length of side 3: ");
        bool isValid3 = double.TryParse(Console.ReadLine(), out double side3);

        if (!isValid1 || !isValid2 || !isValid3 || side1 <= 0 || side2 <= 0 || side3 <= 0)
        {
            Console.WriteLine("Invalid input. Please enter positive numeric values for all sides.");
        }
        else if (!IsTriangle(side1, side2, side3))
        {
            Console.WriteLine("The entered sides do not form a valid triangle.");
        }
        else
        {
            if (side1 == side2 && side2 == side3)
            {
                Console.WriteLine("Triangle is Equilateral.");
            }
            else if (side1 == side2 || side2 == side3 || side1 == side3)
            {
                Console.WriteLine("Triangle is Isosceles.");
            }
            else
            {
                Console.WriteLine("Triangle is Scalene.");
            }
        }

        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }

    static bool IsTriangle(double a, double b, double c)
    {
        // Triangle inequality theorem: sum of any two sides > the third side
        return (a + b > c) && (a + c > b) && (b + c > a);
    }
}
