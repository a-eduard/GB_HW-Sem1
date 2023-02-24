// Напишите программу, которая принимает на вход число N и выдает произведение чисел от 1 до N 
//5 - 120 = 1*2*3*4*5
Console.Clear();
Console.Write("Enter number: ");
int num = int.Parse(Console.ReadLine());
Console.WriteLine($"Сумма равна {num} = {GetMultiply(num)}");

long GetMultiply(int n){
    int result = 1;
    int i = 2;
    if (n < 0){
        i = n;
        n = -1;
    }
    for (; i <=n; i++){ // i <= n; 2 <=3
        result *=i;
    }
    return result;
}
