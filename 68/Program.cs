/*Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29*/

using System;
using static System.Console;

Clear();
Write("Введите первое число: ");
int M = int.Parse(ReadLine());
Write("Введите второе число: ");
int N = int.Parse(ReadLine());

WriteLine(Akkerman(M, N));

static int Akkerman(int M, int N)
{
    if (M == 0)
        return N + 1;
    else
      if ((M != 0) && (N == 0))
        return Akkerman(M - 1, 1);
    else
        return Akkerman(M - 1, Akkerman(M, N - 1));
}