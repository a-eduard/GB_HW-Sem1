Console.Clear();
Console.Write("Введите N: ");
int N = int.Parse(Console.ReadLine());
int i = 1;
int m = N;
if (N < 0)
{
    i = N;
    m = -N;
    N = -1;
}
int[] result = new int[m];
for (int j = 0; i <= N; i++)
{
    result[j] = i * i;
    j++;
}
for (int j = 0; j < m; j++)
{
    Console.Write($"{result[j]} ");
}