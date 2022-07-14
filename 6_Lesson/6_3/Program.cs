void FibNum(int num)
{
    int A = 0;
    int B = 1;

    for (int i = 0; i < num; i++)
    {
        Console.Write($"{A} ");
        (A, B) = (B, A + B);
    }
}

FibNum(7);
