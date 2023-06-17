Console.Clear();
Console.WriteLine("Введите число: ");
int a = int.Parse(Console.ReadLine()!);
for(int i = 2; i <= a; i = i + 2)
{
    Console.Write(i + " "); 
}