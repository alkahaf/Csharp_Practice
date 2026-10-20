Console.Write("Enter first number (a): ");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter second number (b): ");
int b = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"\nBefore swapping: a = {a}, b = {b}");

// Swapping logic
int temp = a;
a = b;
b = temp;

Console.WriteLine($"After swapping:  a = {a}, b = {b}");
