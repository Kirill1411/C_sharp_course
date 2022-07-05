double XY(double x1, double x2, double y1, double y2)
{
return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
}
XY(3, 6, 9, 4);
Console.WriteLine(XY(3, 6, 9, 4));