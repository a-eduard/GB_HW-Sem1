/*Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76*/

int[] array = GetRandomArray(7, 1, 10);
Console.WriteLine(string.Join(", ", array));

int Result(int[] array)
{
    var min = array[0];
    var max = array[0];
    var result = 0;
    for (var i = 0; i < array.Length; i++)
    {
        if (array[i] < array[min]) min = i;
        if (array[i] > array[max]) max = i;
        result = array[max] - array[min];
    }
    return result;
}
Console.WriteLine($"Разница между максимальным и миниимальным числом = {Result(array)} ");

int[] GetRandomArray(int size, int minValue, int maxValue)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(minValue, maxValue + 1);
    }
    return result;
}