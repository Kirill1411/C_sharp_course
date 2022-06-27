int Maxnumber(int num)
{

    if (num % 10 > num / 10)
    {
        return num % 10;
    }
    else
        return num / 10;
}
int SecondNum = new Random().Next(10, 100);

Console.WriteLine(SecondNum);
Console.WriteLine(Maxnumber(SecondNum));
