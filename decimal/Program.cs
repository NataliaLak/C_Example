// Задача 42: Напишите программу, которая будет преобразовывать
// десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10

void DoBoolean(int number)
{
    Console.Write(number + " -> ");
    string text = String.Empty;
    while (number > 0)
    {
        if (number % 2 == 1) text = "1" + text;
        else text = "0" + text;
        number /= 2;
    }
    Console.Write(text);
}

int GetInput(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int number = GetInput("Введите число: ");
DoBoolean(number);