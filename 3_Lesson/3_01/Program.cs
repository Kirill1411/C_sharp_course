﻿void Quarters(int x, int y)
{
if (x == 0 || y == 0) Console.WriteLine("x = 0, y = 0");
else if (x > 0 & y > 0) Console.WriteLine("I");
else if (x < 0 & y > 0) Console.WriteLine("II");
else if (x < 0 & y < 0) Console.WriteLine("III");
else if (x > 0 & y < 0) Console.WriteLine("IV");
}

Quarters(0, 1);
Quarters(2, 1);
Quarters(-2, 1);
Quarters(-2, -1);
Quarters(2, -1);
