void Number(int num)
{
    Console.Write($"{num} -> ");
    if (num < 99)
    {
        Console.Write("Нет третьего числа");
        return;
    }

    while (num > 999)
    {
        num = num / 10;
    }
    Console.WriteLine($"{num % 10}");

}

Number(int.Parse(Console.ReadLine()));
