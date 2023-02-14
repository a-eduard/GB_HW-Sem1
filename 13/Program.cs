Console.Clear();
Console.Write("Enter number: ");
int Number = Convert.ToInt32(Console.ReadLine());
string NumberText = Convert.ToString(Number);
if (NumberText.Length > 2){
  Console.WriteLine("third number -> " + NumberText[2]);
}
else {
  Console.WriteLine("-> no third number");
}