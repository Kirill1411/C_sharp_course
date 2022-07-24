int Numbers(int num)
{
if (num == 0) return 0;
return Numbers(num / 10) + num % 10;

}

Console.WriteLine (Numbers(453));