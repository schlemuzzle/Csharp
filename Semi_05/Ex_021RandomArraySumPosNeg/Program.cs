
int[] GetRandomArray(int size, int minValue, int maxValue)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(minValue, maxValue + 1);
    }
    return result;
}

int[] SumPosNeg(int[] array)
{
    int[] result = new int[2];
    foreach (int e1 in array) // перебирает все значения массива (более удобная форма записи цикла for)
                              // тк не надо задавать условия для i
    {
        result[0] += e1 > 0 ? e1 : 0; // более удобная форма записи цикла if
                                      // if (e1 > 0)
                                      //    result[0] = result + e1;
                                      // else
                                      //    result[0] = result + 0;
        result[1] += e1 < 0 ? e1 : 0;
    }
    return result;
}

int[] array = GetRandomArray(12, -9, 9);
Console.WriteLine(String.Join(", ", array));  // String.Join - позволяет вывести массив в строку Write ("строка", массив)
int[] r = SumPosNeg(array);
Console.WriteLine($"Сумма положительных эл-тов массива = {r[0]}, сумма отрицательных эл-тов = {r[1]}");
Console.WriteLine($"[ {String.Join(", ", array)} ]");