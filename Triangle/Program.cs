// Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник со сторонами такой длины

void ShowTriangle(int a, int b, int c)
{
    if (a >= b + c || b >= a + c || c >= b + a)
    Console.WriteLine("Треугольник со сторонами такой длины существовать не может.");
    else Console.WriteLine("Треугольник со сторонами такой длины существовать может.");
}

int GetInput(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int a = GetInput("Введите первое число: ");
int b = GetInput("Введите второе число: ");
int c = GetInput("Введите третье число: ");
ShowTriangle(a, b, c);
