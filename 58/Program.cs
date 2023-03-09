/*Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18*/

using System;
using static System.Console;

Clear();

Write("Введите количество строк массива 1 массива: ");
int rows1 = int.Parse(ReadLine());

Write("Введите количество столбцов массива 1 массива: ");
int columns1 = int.Parse(ReadLine());

Write("Введите количество строк массива 2 массива: ");
int rows2 = int.Parse(ReadLine());

Write("Введите количество столбцов массива 2 массива: ");
int columns2 = int.Parse(ReadLine());

int[,] array1 = GetArray(rows1, columns1, 0, 10);
int[,] array2 = GetArray(rows2, columns2, 0, 10);
int[,] arrayResult = new int[rows1,columns1];
PrintArray(array1);
WriteLine();
PrintArray(array2);
WriteLine();
ResultMatrix(array1, array2, arrayResult);
PrintArray(arrayResult);


void ResultMatrix(int[,] array1, int[,] array2, int[,] arrayResult)
{
  for (int i = 0; i < arrayResult.GetLength(0); i++)
  {
    for (int j = 0; j < arrayResult.GetLength(1); j++)
    {
      int sum = 0;
      for (int k = 0; k < array1.GetLength(1); k++)
      {
        sum += array1[i,k] * array2[k,j];
      }
      arrayResult[i,j] = sum;
    }
  }
}

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