///Напишите программу, которая принимает на
///вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
void Pows(int num)
{
int count = 1;
while (count <= num)
{
Console.Write($"{Math.Pow(count, 3)} ");
count++;
}
}
Pows(5);
