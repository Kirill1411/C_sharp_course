void Pows(int num)
{
int count = 1;
while (count <= num)
{
Console.Write($"{Math.Pow(count, 2)} ");
count++;
}
}
Pows(5);
