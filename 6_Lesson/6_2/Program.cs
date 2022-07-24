void Binary(int number)
{
    string Dec = "";
    while (number > 0)
    {
        Dec = number % 2 + Dec;
        number /= 2;
    }
    Console.WriteLine(Dec);
}

Binary(45);
