using System;

class SwapWithoutTemp
{
    static void Main()
    {
        Console.Write("Enter first number (a): ");
        int a = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter second number (b): ");
        int b = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"\nBefore swapping: a = {a}, b = {b}");

        // Swapping using arithmetic operations
        a = a + b; // Step 1: Store the sum of both numbers in 'a'
        b = a - b; // Step 2: Subtract new 'a' by original 'b' to get original 'a'
        a = a - b; // Step 3: Subtract new 'a' by new 'b' to get original 'b'

        Console.WriteLine($"After swapping:  a = {a}, b = {b}");
    }
}