Console.WriteLine("Hello, World!");

Console.Write("Enter Number:");

int num = Convert.ToInt32(Console.ReadLine());

if  (num == 0)
{
    Console.WriteLine("Number is Zero");

}

else if (num < 0)
{
    Console.WriteLine("Negative Number: ");
}

else if (num > 0)
{
    Console.WriteLine("Positive Number: ");
}
