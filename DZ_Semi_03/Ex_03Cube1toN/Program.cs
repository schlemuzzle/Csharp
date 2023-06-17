Console.Clear();
Console.Write("Введите число N: ");
int n = int.Parse(Console.ReadLine());
int i = 1;
if (n < i){
    Console.Write("Ведено неверное число.");
    return;
}
Console.Write($"Таблица кубов числа {n}: ");
while (i <= n){
    Console.Write($" {Math.Pow(i, 3)}");
    i++;
}