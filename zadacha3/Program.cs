// 
Console.Clear();
Console.WriteLine("Введите число ");
int number=int.Parse(Console.ReadLine()!);
int temp=-number;
while (temp<=number)
{
 Console.WriteLine(temp); 
 temp=temp+1;  
}
