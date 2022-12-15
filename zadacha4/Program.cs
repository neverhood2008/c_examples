// 
Console.Clear();
Console.WriteLine("Введите число ");
int number=int.Parse(Console.ReadLine()!);
if (number<0)
{number=number*(-1);}
Console.WriteLine(number%10);
