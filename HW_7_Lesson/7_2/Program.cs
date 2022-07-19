/*Напишите программу, которая на вход принимает позиции
элемента в двумерном массиве, и возвращает значение этого
элемента или же указание, что такого элемента нет.*/

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

string Position(int[,] arr, int one, int two)
{
    int row = arr.GetLength(0);
    int column = arr.GetLength(1);

    if (one > row || one <= 0 || two > column || two <= 0)
        return $"{one} {two} -> Такого элемента нет.";
    return $"arr[{one},{two}] = Значение элемента -> {arr[one - 1, two - 1]}";
}

Console.Write("Введите количество строк: ");
int row = int.Parse(Console.ReadLine());

Console.Write("Введите количество столбов: ");
int column = int.Parse(Console.ReadLine());
Console.WriteLine();

int[,] arr_1 = MassNums(row, column, 1, 10);
Print(arr_1);

Console.Write("Введите позицию строки: ");
int First = int.Parse(Console.ReadLine());

Console.Write("Введите позицию столба: ");
int Second = int.Parse(Console.ReadLine());
Console.WriteLine();


Console.WriteLine(Position(arr_1, First, Second));
