// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int SummNumbers(int n)
{
    int result = 0;

    if (n < 0) n = n * (-1);

    for (; n % 10 != 0; n = n / 10)
    {
        result = result + n % 10;
    }
    return result;
}

Console.WriteLine("Введите число");
int n = int.Parse(Console.ReadLine()!);
int result = SummNumbers(n);
Console.WriteLine(result);