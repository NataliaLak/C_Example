// Задача 67: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9

int GetSumDigit(int number)
{
    if (number == 0) return number;
    return number % 10 + GetSumDigit(number / 10);
}

Console.WriteLine("Введите N:");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"{number} -> {GetSumDigit(number)}");
