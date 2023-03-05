/*Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3*/

Console.Clear();
//Console.Write("Введите элементы массива через пробел: ");
//string elements = Console.ReadLine();
int[] array = GetRandomArray(7, -5, 5);
Console.WriteLine(string.Join(", ", array));

Console.WriteLine($"Чисел больше 0 - > {MoreZero(array)}");

int MoreZero(int[] array)
{
    int count = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) count++;
    }
    return count;
}


int[] GetRandomArray(int size, int minValue, int maxValue)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(minValue, maxValue + 1);
    }
    return result;
}