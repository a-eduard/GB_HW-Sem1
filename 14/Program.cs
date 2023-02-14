Console.Clear();
Console.Write("Enter number: ");
int number = int.Parse(Console.ReadLine());

if (number % 7 == 0 && number % 23 == 0){
    Console.WriteLine("cratno");}
else{
    Console.WriteLine("ne cratno");
}