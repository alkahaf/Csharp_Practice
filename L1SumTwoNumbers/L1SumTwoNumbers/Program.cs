//Write a program to read two numbers and print their sum.
using System;
using System.Diagnostics.CodeAnalysis;
class Program
{
    static void Main()
    {
        Console.WriteLine("Enter Number 1: ");
        int num1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter Number 2: ");
        int num2 = Convert.ToInt32(Console.ReadLine());

        int sum = num1 + num2;
        Console.WriteLine("your sum is: " + sum);

    }
}