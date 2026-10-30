//Write a program to read a character and check whether it is an alphabet, digit or special symbol.
Console.Write("Enter a character: ");
char ch = Convert.ToChar(Console.ReadLine());

if ((ch >= 'a' && ch <= 'z') || (ch >= 'A' && ch <= 'Z'))
{
    Console.WriteLine("It is an alphabet.");
}
else if (ch >= '0' && ch <= '9')
{
    Console.WriteLine("It is a digit.");
}
else
{
    Console.WriteLine("It is a special symbol.");
}
