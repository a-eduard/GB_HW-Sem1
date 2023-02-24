//Напишите программу, которая принимает на вход число и выдает количество цифр в числе.
// 456 - 3, 78 - 2, 85236 - 5

int CountNumbers(int n)
{
    int count = 0;
    if (n < 0)
        n *= (-1); //n = n * (-1)
    while (n > 0)
    {
        n /=10; // n = n / 10 n=0
        count++;
    }
    return count;
}

Console.Clear();
Console.Write("Enter number: ");
int s = int.Parse(Console.ReadLine());
Console.WriteLine($"Количество цифр = {CountNumbers(s)}");