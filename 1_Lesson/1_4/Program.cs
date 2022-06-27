int a = int.Parse(Console.ReadLine());
int b = -a;
if (a > 0)
    while (b < a + 1)
    {
        Console.WriteLine(b);
        b += 1;
    }
else
    while (a < b + 1)
    {
        Console.WriteLine(b);
        b -= 1;
    }
