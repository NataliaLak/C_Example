// Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36

int GetSum(int limit)
{
    int summa = 0;
    for (int i = 1; i <= limit; i++)
    {
        summa += i;
    }
    return summa;
}

int GetInput(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int numberA = GetInput("Введите число A:");
Console.WriteLine($"Сумма чисел от 1 до {numberA} ровна {GetSum(numberA)}");