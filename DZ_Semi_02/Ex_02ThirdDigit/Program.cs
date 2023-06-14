Console.Clear();
Console.Write("Введите число из 3 и более знаков: ");
int num = int.Parse(Console.ReadLine());
if (num <= 99) Console.WriteLine("Введенное число слишком мало");
if (num >= 100 && num <= 999) Console.WriteLine($"Третья цифра: {num%10}");
if (num >= 1000 && num <= 9999) Console.WriteLine($"Третья цифра: {(num%100-num%10)/10}");
if (num >= 10000 && num <= 99999) Console.WriteLine($"Третья цифра: {(num%1000-num%100)/100}");
if (num >= 100000 && num <= 999999) Console.WriteLine($"Третья цифра: {(num%10000-num%1000)/1000}");
if (num >= 1000000) Console.WriteLine("Дальше мне надоело...");