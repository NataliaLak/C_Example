Console.Write("Введите число от 1 до 7: ");
int number = int.Parse(Console.ReadLine());

if (number == 1)
{
    Console.WriteLine("Понедельник");
}
 else if (number == 2)
{
    Console.WriteLine("Вторник");
}
else if (number == 3)
{
    Console.WriteLine("Среда");
}
else if (number == 4)
{
    Console.WriteLine("Четверг");
}
else if (number == 5)
{
    Console.WriteLine("Пятница");
}
else if (number == 6)
{
    Console.WriteLine("Суббота");
}
else if (number == 7)
{
    Console.WriteLine("Воскресенье");
}
else
    Console.WriteLine("Сказано же, введите число от 1 до 7");