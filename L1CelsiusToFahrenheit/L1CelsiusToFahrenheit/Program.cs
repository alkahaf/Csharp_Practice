using System;

class CelsiusToFahrenheit
{
    static void Main()
    {
        Console.Write("Enter temperature in Celsius: ");
        double celsius = Convert.ToDouble(Console.ReadLine());

        // Formula: (Celsius * 9 / 5) + 32
        // Note: Using 9.0 / 5.0 ensures floating-point division
        double fahrenheit = (celsius * 9.0 / 5.0) + 32;

        Console.WriteLine($"\n{celsius}°C is equal to {fahrenheit:F2}°F");
    }
}