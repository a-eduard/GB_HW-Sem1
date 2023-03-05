// Напишите, программу которая перевернет одномерный массив (последний элемент будет на первом месте, а первый на последнем)
//[1 2 3 4 5] [5 4 3 2 1]

int[] array = GetRandomArray(7, 1, 10);
Console.WriteLine(string.Join(", ", array));
Console.WriteLine(string.Join(", ", Revers(array)));

int[] Revers(int[] array)
{
    int[] res = new int[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        res[i] = array[array.Length - 1 - i];
    }
    return res;

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