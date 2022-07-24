/*Задайте прямоугольный двумерный массив. Напишите программу,
которая будет находить строку с наименьшей суммой элементов.*/

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

void SumMin(int[,] arr)
{
    int row = arr.GetLength(0);
    int columns = arr.GetLength(1);
    int sum = 100;
    int num = 0;
    int count = 0;

    for (int i = 0; i < row; i++)
    {
        num = 0;
        for (int j = 0; j < columns; j++)
            num += arr[i, j];
        Console.Write($" {num} ");

        if (sum > num)
        {
            sum = num;
            count = i;
        }
    }
    Console.WriteLine();
    Console.Write($" Min position - {count+1} ");

}

Console.WriteLine("Введите число рядов: ");
int row = int.Parse(Console.ReadLine());

Console.WriteLine("Введите число колонок: ");
int column = int.Parse(Console.ReadLine());

Console.WriteLine();

int[,] arr_1 = MassNums(row, column, 1, 10);
Print(arr_1);

SumMin(arr_1);
