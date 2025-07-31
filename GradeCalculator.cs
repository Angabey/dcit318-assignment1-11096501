using System;

class GradeCalculator
{
    static void Main()
    {
        Console.Write("Enter your numeric grade (0-100): ");

        bool isValid = int.TryParse(Console.ReadLine(), out int grade);
        
        if (!isValid || grade < 0 || grade > 100)
        {
            Console.WriteLine("Invalid input. Please enter a number between 0 and 100.");
        }
        else
        {
            string letterGrade;

            if (grade >= 90)
                letterGrade = "A";
            else if (grade >= 80)
                letterGrade = "B";
            else if (grade >= 70)
                letterGrade = "C";
            else if (grade >= 60)
                letterGrade = "D";
            else
                letterGrade = "F";

            Console.WriteLine($"Your letter grade is: {letterGrade}");
        }

        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }
}
