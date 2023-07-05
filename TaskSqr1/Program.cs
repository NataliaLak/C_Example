Console.Write("Введите первое число: ");
int number1 = int.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
int number2 = int.Parse(Console.ReadLine());

if (number1 == number2*number2)
{
    Console.WriteLine($"Число {number1} является квадратом числа: " + number2);
}
else
    Console.WriteLine($"Число {number1} не является квадратом числа: " + number2);