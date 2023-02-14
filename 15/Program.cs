Console.Clear();
Console.Write("Enter number: ");
int number = int.Parse(Console.ReadLine());

if (number <= 5)
{
    Console.WriteLine("No");
    return;
}
else if (number == 6 || number == 7)
{
    Console.WriteLine("Yes");
}
else
{
    Console.WriteLine("Enter a number from 1 to 7");
}