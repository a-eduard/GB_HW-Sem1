Console.Clear();
Console.Write("Enter number 1 to 4: ");
int quarter = int.Parse(Console.ReadLine());

switch (quarter)
{
    case 1:{Console.WriteLine("x>0 y>0");
            break;}
    case 2:{Console.WriteLine("x<0 y>0");
            break;}
    case 3:{Console.WriteLine("x<0 y<0");
            break;}
    case 4:{Console.WriteLine("x>0 y<0");
            break;}
    default:{Console.WriteLine("Ne vernaya chetvert");
            break;}
}
