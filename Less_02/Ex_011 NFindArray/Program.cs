Console.Clear();
int [] array = {13, 23, 56, 22, 78, 98, 55, 44};

int n = array.Length;
int find = 44;
int index = 0;

while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
        break; // прерывает цикл,на случай, если несколько одинаковых искомых значений элементов в массиве
    }
    index++;
}