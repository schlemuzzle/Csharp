Console.Clear();
Console.Write("Введите число из 3 и более знаков: ");
int num = int.Parse(Console.ReadLine()!);
if (num <= 99){
     Console.WriteLine("Введенное число слишком мало");
     return;
}
while (num > 999){
    num /= 10; //num = num / 10
}
 Console.WriteLine($"Третья цифра: {num%10}");