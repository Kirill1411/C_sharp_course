void Print(int[,] arr)
{
    int row_size = arr.GetLength(0);
    int column_size = arr.GetLength(1);

    for (int i = 0; i < row_size; i++)
    {
        for (int j = 0; j < column_size; j++)
        {
            Console.Write($" {arr[i, j],3} ");
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

int[] Vocabulary(int[,] arr)
{
int[] array = new int[10];
foreach (int item in arr) array[item]++;
return array;
}

void PrintArray(int[] arr)
{
for (int i = 0; i < arr.Length; i++)
{

Console.Write($"{i} - {arr[i]} ");
Console.WriteLine();
}
Console.WriteLine();
}

Console.WriteLine("Введите количество строк: ");
int row = int.Parse(Console.ReadLine());

Console.WriteLine("Введите количество столбцов: ");
int column = int.Parse(Console.ReadLine());

int[,] arr_1 = MassNums(row, column, 1, 10);
Print(arr_1);
int[] array_1 = Vocabulary(arr_1);
PrintArray(array_1);
