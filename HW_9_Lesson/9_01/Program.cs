/*Задайте значения M и N. Напишите программу, которая выведет все
чётные натуральные числа в промежутке от M до N с помощью рекурсии.*/

void Power(int M, int N)
{
    if (M >= N) return;
    if (N % 2 != 0) N = N - 1;
    Power(M, N - 1);
    Console.Write($"{N} ");
}

Power(1, 15);
Console.WriteLine();
Power(4, 8);