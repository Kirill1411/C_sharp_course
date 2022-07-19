void PrintIntArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"-{matr[i, j]}- ");

        }
        Console.WriteLine();
    }
}

int[,] FillArrayFunc(int m, int n)
{
    int[,] resultArray = new int[m, n];

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            resultArray[i, j] = new Random().Next(0, 10);
        }
    }

    return resultArray;
}


void FindPosOfNum(int[,] array, int num)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] == num)
            {
                Console.WriteLine($"[{i + 1}, {j + 1}]");
                return;
            }
        }
    }
    Console.WriteLine("не найдено");
}

int[,] matrix = FillArrayFunc(4, 4);
PrintIntArray(matrix);
FindPosOfNum(matrix, 2);
