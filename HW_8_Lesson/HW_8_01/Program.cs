/* Задайте двумерный массив. Напишите программу, которая
упорядочит по убыванию элементы каждой строки двумерного массива.*/

void Print(int[,] arr)
{
    int row_size = arr.GetLength(0);
    int column_size = arr.GetLength(1);

    for (int i = 0; i < row_size; i++)
    {
        for (int j = 0; j < column_size; j++)
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

void order(int[,] arr)
{
    int row = arr.GetLength(0);
    int columns = arr.GetLength(1);

    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            for (int o = 0; o < columns - j - 1; o++)
                if (arr[i, o] < arr[i, o + 1])
                    (arr[i, o], arr[i, o + 1]) = (arr[i, o + 1], arr[i, o]);
        }
    }
}

Console.WriteLine("Введите число рядов: ");
int row = int.Parse(Console.ReadLine());

Console.WriteLine("Введите число колонок: ");
int column = int.Parse(Console.ReadLine());

Console.WriteLine();

int[,] arr_1 = MassNums(row, column, 1, 10);
Print(arr_1);

order(arr_1);
Print(arr_1);