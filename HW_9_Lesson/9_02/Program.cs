/*Задайте значения M и N. Напишите программу, которая найдёт сумму
натуральных элементов в промежутке от M до N с помощью рекурсии.*/

int Power(int M, int N)
{
    if (N < M) return 0;
    return Power(M, N - 1) + N;
}

Console.WriteLine(Power(1, 15));
Console.WriteLine(Power(4, 9));