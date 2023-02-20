//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
Console.Clear();
Console.Write("Enter number: ");
int Number = Convert.ToInt32(Console.ReadLine());
string NumberText = Convert.ToString(Number);
if (NumberText[0] == NumberText[4] && NumberText[1] == NumberText[3]){
  Console.WriteLine("Yes");
}
else {
  Console.WriteLine("No");
}