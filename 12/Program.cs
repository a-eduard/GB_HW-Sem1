Console.Clear();
Console.Write("Enter number1: ");
int number1 = int.Parse(Console.ReadLine());
Console.Write("Enter number2: ");
int number2 = int.Parse(Console.ReadLine());
if (number1 / number2 == 0){
    Console.WriteLine("cratno");}
else{
    Console.WriteLine($"ne cratno, ostatoc - {number1 % number2}");
}
