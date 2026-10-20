Console.WriteLine("Hello, World!");
Console.Write("Enter Number: ");
int num  = Convert.ToInt32(Console.ReadLine());
if  (num % 2 == 0 )
{
    Console.WriteLine($"Number: {num:F2} is Even");
}
else
{
    Console.WriteLine($"Number: {num:F2} is Odd");
}