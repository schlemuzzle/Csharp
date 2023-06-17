Console.Clear();
Console.Write("Введите первую координату A: ");
double xA = double.Parse(Console.ReadLine()!);
Console.Write("Введите вторую координату A: ");
double yA = double.Parse(Console.ReadLine()!);
Console.Write("Введите третью координату A: ");
double zA = double.Parse(Console.ReadLine()!);
Console.Write("Введите первую координату B: ");
double xB = double.Parse(Console.ReadLine()!);
Console.Write("Введите вторую координату B: ");
double yB = double.Parse(Console.ReadLine()!);
Console.Write("Введите третью координату B: ");
double zB = double.Parse(Console.ReadLine()!);

double result = Math.Sqrt(Math.Pow(xA - xB, 2) + Math.Pow(yA - yB, 2) + Math.Pow(zA - zB, 2));
Console.WriteLine($"Искомое расстояние: {result:f2}");