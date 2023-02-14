Console.Clear();

int num = new Random().Next(10, 100);
int a1 = num / 10; //a1 = 162 /100 = 1
int a2 = num % 10;// a2 = 162 % 10 = 2
int max = a1;
if (max < a2)
    max = a2;
Console.WriteLine($"Максимальная цифра числа {num} -> {max}");