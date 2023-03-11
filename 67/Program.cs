/***Задача 67:**Напишите программу, 
которая будет принимать на вход число и возвращать сумму его цифр.
453 -> 12
45 -> 9*/
using System;
using static System.Console;


Clear();
Write("Введите число: ");
int m = int.Parse(ReadLine());

WriteLine($"{m}->{SumNumbers(m)}");
int sum = 0;
while(m > 0){
    sum += m % 10; // <=> sum = sum + m % 10
    m /= 10; // <=> m = m / 10
}
WriteLine($"{sum}");


int SumNumbers(int number)
{
    if (number == 0)
        return 0;
    return (number % 10 + SumNumbers(number / 10));
}
// Console.Clear();
// Console.Write("Введите A: ");
// int A = int.Parse(Console.ReadLine());
// Console.Write("Введите B: ");
// int B = int.Parse(Console.ReadLine());
// Console.WriteLine(PowNumbers(A, B));

// int PowNumbers(int a, int b)
// {
//     if (b == 0)
//     {
//         return 1;
//     }
//     a *= PowNumbers(a, b - 1);
//     return (a);
// }