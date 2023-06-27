Console.Clear();

Console.WriteLine("Введите целое положительное число: ");
int a = Convert.ToInt32(Console.ReadLine());// int.Parse - всеядный, с числами лучше использовать этот метод

// способ через цикл:

int sum = 0;

for (int i = 1; i <= a; i++)
{
    sum = sum + i; // sum += i
}

Console.WriteLine($"Сумма чисел от 1 до {a} = {sum}");

// способ через функцию (метод в C#):

int sumNumbers = SumNumbers(a);
Console.WriteLine($"Сумма чисел от 1 до {a} = {sumNumbers}");

int SumNumbers(int number) //number = a
{
    int sum = 0;

    for (int i = 1; i <= number; i++)
    {
        checked // блок проверки на переполнение типа (ошибку, в данном случае - если sum вывалится за разряд 32 бит)
        {
            sum = sum + i; 
        }
        
    }

    return sum;
}
//пример вызова и использования:
int num1 = 25, num2 = 47;

int sumNumbers1 = SumNumbers(num1);
Console.WriteLine($"Сумма чисел от 1 до {num1} = {sumNumbers1}");

int sumNumbers2 = SumNumbers(num2);
Console.WriteLine($"Сумма чисел от 1 до {num2} = {sumNumbers2}");