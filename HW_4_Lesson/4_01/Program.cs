/// Напишите цикл, который принимает на вход
///два числа (A и B) и возводит число A в натуральную
///степень B.

int Extent(int num1, int num2)
{
    int ext = num1;
    for (int i = 1; i < num2; i++)
    {
        ext *= num1;
    }
    return ext;
}
Console.WriteLine(Extent(3, 5));