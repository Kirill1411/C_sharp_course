void Print(int[] arr)
{
    int size = arr.Length;

    for (int i = 0; i < size; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
}

int[] MassNums(int size)
{
    int[] arr = new int[size];

    for (int i = 0; i < size; i++)
    {
        arr[i] = new Random().Next(-9, 10);
    }
    return arr;
}

int[] ProductOfPairsOfNumbersInArray(int[] originalArray)
{
    int oLength = originalArray.Length;
    int[] result = new int[oLength / 2 + oLength % 2];
    for (int i = 0; i < (oLength / 2); i++)
    {
        result[i] = originalArray[i] * originalArray[oLength - i - 1];
    }

    if (oLength % 2 != 0)
    {
        result[oLength / 2] = originalArray[oLength / 2];
    }

    return result;
}

int[] originalArray = MassNums(6);
Print(originalArray);
Print(ProductOfPairsOfNumbersInArray(originalArray));