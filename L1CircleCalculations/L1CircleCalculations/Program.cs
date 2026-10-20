using System;

class CircleCalculations
{
    static void Main()
    {
        Console.Write("Enter the radius of the circle: ");
        double radius = Convert.ToDouble(Console.ReadLine());

        // Formulae: Area = π * r², Circumference = 2 * π * r
        //double area = Math.PI * Math.Pow(radius, 2);
        //double circumference = 2 * Math.PI * radius;
        const double PI = 3.14;
        double area = PI * (radius * radius);
        double circumference = 2 * PI * radius;




        Console.WriteLine($"\nArea of the circle: {area:F2}");
        Console.WriteLine($"Circumference of the circle: {circumference:F2}");
    }
}