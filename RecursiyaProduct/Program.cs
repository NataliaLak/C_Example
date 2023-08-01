// Задача 69: Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8

int GetProduct(int number, int power)
{
    if (power == 0) return 1;
    return number * GetProduct(number, power -1);
}

Console.Write("Введите A:");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите B:");
int number2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"{number1} -> {GetProduct(number1, number2)}");