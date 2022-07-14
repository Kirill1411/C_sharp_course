/*: Пользователь вводит с клавиатуры M чисел.
Посчитайте, сколько чисел больше 0 ввёл пользователь*/

int Number(int size)
{
    int count = 0;

    for (int i = 1; i <= size; i++)
    {
        Console.Write($" Число {i}: ");
        int num = int.Parse(Console.ReadLine());
        if (num > 0) count++;
    }
    return count;
}

Console.Write("Введите количество чисел: ");
int num = int.Parse(Console.ReadLine());
Console.WriteLine($" Количество чисел > 0: {Number(num)}");
