// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
//3, 5 -> 243 (3⁵)
//2, 4 -> 16
Console.Clear();
Console.Write("Enter number A: ");
int A = int.Parse(Console.ReadLine());
Console.Write("Enter number B: ");
int B = int.Parse(Console.ReadLine());
Console.WriteLine($"Результат = {Sum(A, B)}");

if (B == 0){
  Console.WriteLine("B должно быть больше 0");
};

int Sum(int A, int B)
{
    int C = 1;
    for (int i = 0; i < B; i++)
    {
        C = C * A;
    }
    return C;
}