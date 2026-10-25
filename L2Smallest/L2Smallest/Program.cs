Console.WriteLine("Smallest Among Three Numbers!");

Console.Write("Enter Number 1: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter Number 2: ");
int num2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter Number 3: ");
int num3 = Convert.ToInt32(Console.ReadLine());

if (num1 <= num2 && num1 <= num3)
{
    Console.WriteLine($"{num1} is the smallest");
}
else if (num2 <= num1 && num2 <= num3)
{
    Console.WriteLine($"{num2} is the smallest");
}
else
{
    Console.WriteLine($"{num3} is the smallest");
}