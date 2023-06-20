Console.Clear();
// Вид 1 - ничего не возвращает и не принимает
void Method1()
{
    Console.WriteLine("Something");
}
//Method1();

// Вид 2 - ничего не возвращает, но может принимать какие-нибудь аргументы
void Method2(string msg, int count)
{
    int i = 0;
    while(i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
}
// Method2("Something...", 4); ----  или можно именовать аргументы, тогда порядок записи неважен:
// Method2(msg: "Something...", count: 5);  ----- или 
// Method2(count: 5, msg: "Something...");

// Вид 3 - что-то возвращает, но ничего не принимаeт
int Method3()
{
    return DateTime.Now.Year;
}
int year = Method3();
// Console.WriteLine(year);

// Вид 4 - что-то возвращает, что-то принимаeт

string Method4(int count, string text)
{
    string result = String.Empty;
    for(int i = 0; i < count; i++)
    {
        result = result + text;
    }
    return result;
}
string res = Method4(10, "something ");
// Console.WriteLine(res);

// Цикл в цикле - таблица умножения
for(int i = 2; i <=10; i++)
{
    for(int j = 1; j <=10; j++)
    {
        Console.WriteLine($"{i} x {j} = {i *j}");
    }
    Console.WriteLine();
}