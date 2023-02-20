// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
Console.Clear();
Console.Write("Enter number: ");
int number = int.Parse(Console.ReadLine());
int i = 1;
int m = number;
if (number < 0)
{
    i = number;
    m = -number;
    number = -1;
}
int[] result = new int[m];
for (int j = 0; i <= number; i++)
{
    result[j] = i * i * i;
    j++;
}
for (int j = 0; j < m; j++)
{
    Console.Write($"{result[j]} ");
}
