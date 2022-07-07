///Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

int Sum(int num)
{
    int AllSum = 0;
    while (num > 0)
    {
        AllSum += num % 10;
        num /= 10;
    }
    return AllSum;
}

Console.WriteLine(Sum(452));
Console.WriteLine(Sum(82));
Console.WriteLine(Sum(9012));
