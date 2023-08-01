// Задача 63: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"

string Recursia (int n)
{
    if (n == 1) return n.ToString();
    return Recursia(n-1) + ", " + n;
}

Console.Writed("Введите N:");
int n = Convert.ToInt32(Console.ReadLine());    
Console.WriteLine($"{Recursia(n)}");
