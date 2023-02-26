// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int Number(int N)
{
    Console.Write("Введите число: ");
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

int SumAllDigit(int num)
{
    int sum = 0;
    num = 0;
    while (num != 0)
    {
        sum += num % 10;
        num = num / 10;
    }
    if (sum < 0)
        sum = -sum;
    return sum;
}


int sumN = SumAllDigit(num);
Console.WriteLine($"Сумма цифр числа = {sumN}");

