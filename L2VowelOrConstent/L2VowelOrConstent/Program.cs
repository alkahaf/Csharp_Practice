Console.Write("Enter a character: ");
char ch = Convert.ToChar(Console.ReadLine());

if (ch == 'a' || ch == 'e' || ch == 'i' ||
    ch == 'o' || ch == 'u' || ch == 'A' ||
    ch == 'E' || ch == 'I' || ch == 'O' || ch == 'U')
{
    Console.WriteLine("It is a vowel.");
}
else if ((ch >= 'a' && ch <= 'z') ||
         (ch >= 'A' && ch <= 'Z'))
{
    Console.WriteLine("It is a consonant.");
}
else
{
    Console.WriteLine("Invalid input! Please enter an alphabet.");
}