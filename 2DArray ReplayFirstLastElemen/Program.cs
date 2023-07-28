// Задача 53: Задайте двумерный массив. Напишите программу, 
// которая поменяет местами первую и последнюю строку массива.

// Задача 53: Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.

void SwapFirstLastRows(int[,] array)
{
    {
        int i = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            int temp = array[i,j];
            array[i,j] = array[array.GetLength(0)-1,j];
            array[array.GetLength(0)-1,j] = temp;
        }
        Print2DArray(array);
    }
}

void Print2DArray (int [,] array)
{
    Console.WriteLine("Новый массив выглядит так:");
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(" " + array[i,j]);
        }
    Console.WriteLine();
    }
}

int[,] Create2DArray (int rows, int columns)
{
    int[,] array = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i,j] = new Random().Next (1,100);
            Console.Write(" " + array[i,j]);
        }
    Console.WriteLine();
    }
    return array;
}

int GetInput (string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int rows = GetInput("Введите число строк: ");
int columns = GetInput("Введите число столбцов: ");
int [,] array = Create2DArray(rows, columns);
SwapFirstLastRows(array);