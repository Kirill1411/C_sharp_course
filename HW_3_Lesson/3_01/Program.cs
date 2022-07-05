////Напишите программу, которая принимает на
////вход пятизначное число и проверяет, является ли оно
////палиндромом

void PrintArray(int array)
{
    string number = array.ToString();
    int size = number.Length - 1;
    int i = 0;
    string flag = "Yes";
    while (i < size / 2)
    {
        if (number[i] != number[size - i])
        {
            flag = "No";
            break;
        }
        i++;
    }
    Console.WriteLine(flag);
}
PrintArray(14212);
PrintArray(23432);
PrintArray(12821);