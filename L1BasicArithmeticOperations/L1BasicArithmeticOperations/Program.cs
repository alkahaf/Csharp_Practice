using System;
class Program
{
    static void Main()
    {
        Console.Write("Enter Number 1: ");
        int num1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter Number 2: ");
        int num2 = Convert.ToInt32(Console.ReadLine());

        int sum = num1 + num2;
        int difference = num1 - num2;
        int product = num1 * num2;

        Console.WriteLine($"\nYour sum is: {sum}");
        Console.WriteLine($"Your diff is: {difference}");
        Console.WriteLine($"Your mul is: {product}");

        if (num2 != 0)
        {
            int remainder = num1 % num2;
            double division = (double)num1 / num2;

            Console.WriteLine($"Your remainder is: {remainder}");
            Console.WriteLine($"Your division is: {division}");
        }
        else
        {
            Console.WriteLine("Cannot divide by zero.");
        }

    }
}