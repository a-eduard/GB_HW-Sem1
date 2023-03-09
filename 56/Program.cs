/*Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка*/

using System;
using static System.Console;

Clear();

Write("Введите количество строк массива: ");
int rows = int.Parse(ReadLine());

Write("Введите количество столбцов массива: ");
int columns = int.Parse(ReadLine());

int[,] array = GetArray(rows, columns, 0, 10);
PrintArray(array);


int LineMin= 0;
int SumLine = ElementSum(array, 0);
for (int i = 1; i < array.GetLength(0); i++)
{
  int tempSumLine = ElementSum(array, i);
  if (SumLine > tempSumLine)
  {
    SumLine = tempSumLine;
    LineMin = i;
  }
}

Console.WriteLine($"\n{LineMin + 1} - строкa с наименьшей суммой ({SumLine}) элементов ");

int[,] GetArray(int m, int n, int min, int max)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(min, max + 1);
        }

    }
    return result;
}


int ElementSum(int[,] array, int i)
{
  int SumLine = array[i, 0];
  for (int j = 1; j < array.GetLength(1); j++)
  {
    SumLine += array[i, j];
  }
  return SumLine;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Write($"{array[i, j]} ");
        }
        WriteLine();
    }
}