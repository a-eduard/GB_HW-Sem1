//24 Напишите программу, которая принимает на вход число А и выдает сумму чисел от 1 до А
//а=5, sum=1+2+3+4+5
int GetSum(int n)
{
    int sum = 0;
    for (int i = 1; i <= n; i++)
        sum += i;
    return sum;
}

Console.Clear();
Console.Write("Enter number: ");
int n = int.Parse(Console.ReadLine());
//GetSum(n);
int result = GetSum(n);
Console.WriteLine($"Sum from 1 to {n} = {result}");
