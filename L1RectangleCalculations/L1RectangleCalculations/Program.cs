using System;

class RectangleCalculations
{
    static void Main()
    {
        Console.Write("Enter the length of the rectangle: ");
        double length = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the breadth of the rectangle: ");
        double breadth = Convert.ToDouble(Console.ReadLine());

        // Formulae: Area = length * breadth, Perimeter = 2 * (length + breadth)
        double area = length * breadth;
        double perimeter = 2 * (length + breadth);

        Console.WriteLine($"\nArea of the rectangle: {area:F2}");
        Console.WriteLine($"Perimeter of the rectangle: {perimeter:F2}");
    }
}