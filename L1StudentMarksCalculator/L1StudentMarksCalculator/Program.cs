using System;

class StudentMarksCalculator
{
    static void Main()
    {
        double total = 0;
        int numberOfSubjects = 5;

        // Reading marks for 5 subjects using a loop
        for (int i = 1; i <= numberOfSubjects; i++)
        {
            Console.Write($"Enter marks for Subject {i}: ");
            double marks = Convert.ToDouble(Console.ReadLine());
            total += marks;
        }

        double average = total / numberOfSubjects;

        Console.WriteLine($"\nTotal Marks: {total:F2}");
        Console.WriteLine($"Average Marks: {average:F2}");
    }
}