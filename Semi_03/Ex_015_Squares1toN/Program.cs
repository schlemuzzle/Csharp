Console.Clear();
Console.Write("Введите число N: ");
int n = int.Parse(Console.ReadLine());
int i = 1;
// for (i = 1; i <= n; i++); - чет не работает...
if (n < i){
    Console.Write("Ведено неверное число");
    return;
}
Console.Write("Таблица квадратов числа N:");
while (i <= n){
    Console.Write($" {Math.Pow(i, 2)}");
    i++;
}
