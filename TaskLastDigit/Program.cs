Console.Write("Введите трёхзначное число: ");
int number = int.Parse(Console.ReadLine());

int LastDigit = number % 10;

Console.Write("Последняя цифра числа: " + LastDigit);