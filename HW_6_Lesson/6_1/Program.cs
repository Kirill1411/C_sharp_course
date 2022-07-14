/* Напишите программу, которая будет создавать
 копию заданного массива с помощью поэлементного копирования.*/


void Print(int[,] arr)
{
    int column_size = arr.GetLength(1);

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($" {arr[i, j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] MassNums(int row, int column, int from, int to)
{
    int[,] arr = new int[row, column];

    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            arr[i, j] = new Random().Next(from, to);
        }
    }
    return arr;
}

int[,] CopyMass(int[,] arr)
{
    int[,] new_arr = new int[arr.GetLength(0), arr.GetLength(1)];

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            new_arr[i, j] = arr[i, j];
        }
    }
    return new_arr;
}

int[,] arr_1 = MassNums(5, 5, 1, 5);
Print(arr_1);
int[,] arr_1_new = CopyMass(arr_1);
Print(arr_1_new);

