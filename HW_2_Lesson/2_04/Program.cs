Console.WriteLine("Ведите число");
int day = int.Parse(Console.ReadLine());

if (day == 6 || day == 7)
{
    Console.WriteLine("Выходной");
}
if (day < 6)
{
    Console.WriteLine("Рабочий день");
}
if (day > 7 )
{
    Console.WriteLine("Такого дня нет.");
}


