Console.Clear();

void Towers(string with = "1", string on = "3", string some = "2", int count = 4)
//string with = "1" - начальный шпиль
//string some = "2" - промежуточный шпиль
//string on = "3"   - конечный шпиль
//int count = 3     - кол-во блинчиков
{
    if (count > 1) Towers(with, some, on, count - 1);
    Console.WriteLine($"{with} >> {on}");
    if (count > 1) Towers(some, on, with, count - 1);
}

Towers();
