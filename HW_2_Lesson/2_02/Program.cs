void Number()
{
    int num = new Random().Next(100, 1000);
    Console.WriteLine(num);
    num = num / 100 * 10 + num % 10;
    Console.WriteLine(num);
}
Number();






