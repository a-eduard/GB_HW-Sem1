// **Задача 40:**Напишите программу, 
// которая принимает на вход три числа и проверяет, может ли 
// существовать треугольник с сторонами такой длины.
// ❗ **Теорема о неравенстве треугольника:
// **каждая сторона треугольника меньше суммы двух других сторон.
Console.Clear();
Console.Write("Введите стороны треугольника через пробел: ");


string[] st = Console.ReadLine().Split(' ');
int A = int.Parse(st[0]);
int B = int.Parse(st[1]);
int C = int.Parse(st[2]);

if (Res(A, B, C))
{
    Console.WriteLine("Да");
}
else{
    Console.WriteLine("Нет");
}

bool Res(int A, int B, int C)
{
    return (((A + B) > C) && ((A + C) > B && (B + C) > A));
}

