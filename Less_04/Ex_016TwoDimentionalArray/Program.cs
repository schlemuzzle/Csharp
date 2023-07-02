Console.Clear();

void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}

void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(1, 10);//[1; 10)
        }
    }
}
//                       matr.GetLength(0) - обращение к количеству строк
//int[,] matrix = new int[3, 4];
//                            matr.GetLength(1) - обращение к количеству столбцов

int[,] matrix = new int[3, 4];

FillArray(matrix);
PrintArray(matrix);