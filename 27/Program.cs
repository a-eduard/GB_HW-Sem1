// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12
Console.Clear();
Console.Write("Enter number: ");
int s = int.Parse(Console.ReadLine());
Console.WriteLine($"Сумма числа {s} = {CountNumbers(s)}");

int CountNumbers(int s)
{
    int sum = 0;
    while (s > 0)
    {
        sum += s % 10;
        s = s / 10;
    }
    return sum;
}