int Power (int A, int B)
{
if (B == 0) return 1;
return Power (A, B - 1) * A;
}

Console.Write(Power(3, 5));
