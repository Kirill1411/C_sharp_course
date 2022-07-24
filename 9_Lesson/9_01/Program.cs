void ValuesSet(int num)
{
if (num == 0) return;
ValuesSet(num - 1);
Console.Write($"{num}, ");
}
ValuesSet(5);
