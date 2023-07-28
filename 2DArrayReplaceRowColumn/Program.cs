void PrintInvert2DMassive(int[,] massive)
{
    Console.WriteLine("Выводим инвертированный массив:");
    for (int i = 0; i < massive.GetLength(0); i++)
    {
        for (int j = 0; j < massive.GetLength(1); j++)
        {
            Console.Write($"{massive[j,i]}\t", -5);
        }
        Console.WriteLine();
    }
}

void Print2DMassive(int[,] massive)
{
    for (int i = 0; i < massive.GetLength(0); i++)
    {
        for (int j = 0; j < massive.GetLength(1); j++)
        {
            Console.Write($"{massive[i,j]}\t", -5);
        }
        Console.WriteLine();
    }
}

int[,] Create2DMassive(int rows, int columns, int startValue, int finishValue)
{
    int[,] matrix = new int[rows, columns];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = new Random().Next(startValue, finishValue + 1);
        }
    }
    return matrix;
}

int GetInput (string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int m = GetInput("Введите количество строк массива: ");
int n = GetInput("Введите количество столбцов массива: ");
int[,] massive = Create2DMassive(m, n, 1, 100);
Print2DMassive(massive);
if(m == n) PrintInvert2DMassive(massive);
else Console.WriteLine("Инвертировать массив невозможно!");
