void Quarters(int Number)
{
if (Number == 1) Console.WriteLine("x > 0  y > 0");
else if (Number == 2) Console.WriteLine("x < 0  y > 0");
else if (Number == 3) Console.WriteLine("x < 0  y < 0");
else if (Number == 4) Console.WriteLine("x > 0  y < 0");
else Console.WriteLine("не верно");
}

Quarters (1);
Quarters (4);
Quarters (6);
