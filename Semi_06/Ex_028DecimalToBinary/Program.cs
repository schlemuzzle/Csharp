Console.Clear();

Console.WriteLine("Введите число и систему через пробел: ");
string[] sides = Console.ReadLine()!.Split(' ', StringSplitOptions.RemoveEmptyEntries);
int number = int.Parse(sides[0]);
int sys = int.Parse(sides[1]);

string res = DecToNum(number, sys);

Console.WriteLine($"Число {number} в {sys}-ичной системе -> {res}");


//Универсальный математический для перевода из 10 в любую
string DecToNum(int decNumber, int otherSystem)
{
    string res = "";
    string nums = "0123456789ABCDEF";
    while (decNumber > 0)
    {
        int ost = decNumber / otherSystem;
        res = nums[decNumber - otherSystem * ost] + res;
        decNumber /= otherSystem;
    }
    return res;
}