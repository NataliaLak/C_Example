// Задача 44: Не используя рекурсию, выведите первые N чисел
// Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

void DoFibonachi (int number)
{
    Console.Write ("Если N = " + number + " -> 0 1");
    int number1 = 0;
    int number2 = 1;
    for (int i = 0; i < number; i++)
    {
        int number3 = number1+number2;
        number1=number2;
        number2=number3;
        Console.Write(" " + number3);
    }    
}

int GetInput (string text)
{
    Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

int number = GetInput("Введите количество чисел: ");
DoFibonachi(number);
