Console.Write("Введите число M: ");
int M = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());

void Sequence(int M, int N)
{
if (N < M) return;
Sequence(M, N-1);
Console.Write($"{N}, ");
}
Sequence(M, N);