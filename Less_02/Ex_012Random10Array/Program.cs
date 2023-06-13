Console.Clear();
// void - метод, который не возвращает значения, тогда нельзя использовать return

void FillArray(int[] massiv) // FillArray - запоняет массив
{
    int length = massiv.Length;
    int index = 0;
    while (index < length)
    {
        massiv [index] = new Random().Next(1, 10);
        index++;
    }
}

void PrintArray(int[] mass) // PrintArray - выводит массив в консоль
{
    int count = mass.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(mass[position]);
        position++;
    }
}

int IndexOf(int[] massiv, int find)
{
    int count = massiv.Length;
    int index = 0;
    int position = -1; // для случая, когда в массиве нет искомого (иначе отразится 0 как нулевой индекс(первое число в массиве))
    while (index < count)
    {
        if (massiv[index] == find)
        {
            position = index;
            break; // прерывает на первом искомом элементе (по умолчанию выводит последний)
        }
        index++;
    }
    return position;
}

int[] array = new int [10]; // создаем новый массив array из 10 элементов (по умолчанию заполнен нулями)

FillArray(array);
PrintArray(array);

Console.WriteLine();

int pos = IndexOf(array, 4);
Console.WriteLine(pos);
