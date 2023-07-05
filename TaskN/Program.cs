Console.Write("Введите число N: ");
int n = int.Parse(Console.ReadLine());
n = Math.Abs(n);

Console.WriteLine($"Целые числал в промежутке от -{n} до {n}: ", n);

for (int i = -n; i <= n; i++)
{
    Console.Write(i+", ");
}
Console.Write(n);