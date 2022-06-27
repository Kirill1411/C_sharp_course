int num1 = int.Parse(Console.ReadLine());
int num2 = int.Parse(Console.ReadLine());
int num3 = int.Parse(Console.ReadLine());
int max = num1;

if (max < num2)
{
    max = num2;
}
if (max < num3)
{
    max = num3;
}
Console.WriteLine(max);
