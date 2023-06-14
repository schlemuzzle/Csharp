Console.Clear();
Console.Write("Введите первое число: ");
int num1 = int.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
int num2 = int.Parse(Console.ReadLine());
if (num2 == Math.Pow(num1, 2) || num1 == Math.Pow(num2, 2)) Console.WriteLine("Да, одно из чисел - квадрат другого");
else Console.WriteLine("Нет");
// 