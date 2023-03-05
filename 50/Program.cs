/*Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же 
указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4*/

using System;
using static System.Console;

Clear();

Console.WriteLine("введите номер строки");
int rows = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("введите номер столбца");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] array = GetArray(5, 5); // создаем двумерный массив
PrintArray(array); //выводим двумерный массив
SeachNumber(array);

int[,] GetArray(int m, int n)// функция для заполнения массива
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(-100, 100) / 10;
        }
    }
    return result;
}

void PrintArray(int[,] inArray)//вывод массива вместо Console.WriteLine
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Write($"{inArray[i,j]} ");
        }
        WriteLine();
    }
}

int[,] SeachNumber(int[,] array)
{
    if (rows > array.GetLength(0) || columns > array.GetLength(1))
{
    Console.WriteLine("такого элемента нет");
}
else
{
    Console.WriteLine($"значение элемента {rows} строки и {columns} столбца равно {array[rows-1,columns-1]}");
}

return array;
}
