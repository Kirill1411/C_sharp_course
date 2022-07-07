/// Напишите программу, которая задаёт массив из 8 элементов случайными числами и выводит их на экран.
/// Оформите заполнение массива и вывод в виде функции (пригодится в следующих задачах)

void ArrayFill(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 8);
    }
}

void ArrayPrint(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}

int[] array = new int[8];
ArrayFill(array);
ArrayPrint(array);
