/*Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0*/

//Извиняюь, очень топорное решение, но яне понимаю как реализовать обращение к индексу. 
int[] array = GetRandomArray(10, 0, 30);
Console.WriteLine(string.Join(", ", array));

int Sum(int[] array)
{
    int sum = 0;
    for (int i = 1; i < array.Length; i = i + 2)
    {
        sum += array[i];
    }
    return sum;
}

Console.WriteLine($"Сумма нечетных чисел = {Sum(array)} ");

int[] GetRandomArray(int size, int minValue, int maxValue)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(minValue, maxValue + 1);
    }
    return result;
}