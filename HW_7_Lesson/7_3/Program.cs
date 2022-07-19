/*Задайте двумерный массив из целых чисел. Найдите
среднее арифметическое элементов в каждом столбце.*/

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

void ArithmeticalMean(int[,] arr)
{
    int row = arr.GetLength(0);
    int column = arr.GetLength(1);
    double result;
    for (int i = 0; i < column; i++)
    {
        result = 0;
        for (int j = 0; j < row; j++) result += arr[j, i];
        Console.Write($"{Math.Round(result / row, 2)}; ");
    }
}


Console.Write("Введите количество строк: ");
int row = int.Parse(Console.ReadLine());

Console.Write("Введите количество столбов: ");
int column = int.Parse(Console.ReadLine());
Console.WriteLine();

int[,] arr_1 = MassNums(row, column, 1, 10);
Print(arr_1);
ArithmeticalMean(arr_1);