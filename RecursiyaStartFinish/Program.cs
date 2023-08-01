// Задача 65: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 6, 7, 8"

string ShowNumber(int startNumber, int finishNumber)
{
    if (finishNumber == startNumber) return startNumber.ToString();
    return ShowNumber(startNumber, finishNumber - 1) + ", " + finishNumber;
}

int GetInput(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int m = GetInput("Введите число m: ");
int n = GetInput("Введите число n: ");
Console.WriteLine($"{ShowNumber(m, n)}");