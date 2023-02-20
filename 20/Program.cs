Console.Clear();
Console.Write("Введите координаты X1: ");
double X1 = double.Parse(Console.ReadLine());
Console.Write("Введите координаты Y1: ");
double Y1 = double.Parse(Console.ReadLine());
Console.Write("Введите координаты X2: ");
double X2 = double.Parse(Console.ReadLine());
Console.Write("Введите координаты Y2: ");
double Y2 = double.Parse(Console.ReadLine());

double d = Math.Sqrt(Math.Pow(X1 - X2, 2) + Math.Pow(Y1 - Y2, 2));

Console.WriteLine($"d={d:f2}");//f2 количесво цифр после запятой
