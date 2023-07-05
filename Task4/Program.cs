// Напишите программу, которая на вход принимает три числа и выдаёт максимальное из них.
Console.Write("Введите первое число: ");
int number1 = int.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
int number2 = int.Parse(Console.ReadLine());
Console.Write("Введите третье число: ");
int number3 = int.Parse(Console.ReadLine());

if (number1 > number2)
{
    Console.Write("Максимальное число: " + number1);
}
else if(number1 > number3)
{
    Console.Write("Максимальное число: " + number1);
}
if (number2 > number1)
{
    Console.Write("Максимальное число: " + number2);
}
else if(number2 > number3)
{
    Console.Write("Максимальное число: " + number2);
}

 else
    Console.Write("Оба числа равны.");   