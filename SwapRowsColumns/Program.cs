// Задача 55: Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы.
//  В случае, если это невозможно, программа должна вывести сообщение для пользователя.

void SwapRowsToColumns(int[,] array)
{
    if (array.GetLength(0) != array.GetLength(1)) Console.Write("Заменить строки на столбцы невозможно: ");
    else 
    {
        int count = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = count; j < array.GetLength(1); j++)
            {
                int temp = array[i,j];
                array[i,j] = array [j,i];
                array[j,i] = temp;
            }
            count++;
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
SwapRowsToColumns(array);