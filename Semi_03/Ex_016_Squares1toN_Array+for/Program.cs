Console.Clear();
Console.Write("Введите число N: ");
int N = int.Parse(Console.ReadLine());
int[] result = new int [N];
for (int i = 1; i <= N; i++)
    result[i - 1] = i * i;
//i-1 для расчета с нулевого индекса массива и до последнего (иначе считает с первого до последнего + 1)
for (int i = 0; i < N; i++)
    Console.Write($" {result[i]}");
Console.WriteLine();
Console.WriteLine("Второй способ: ");// без массива
for (int i = 1; i <=N; i++)
    Console.Write($" {i * i} ");