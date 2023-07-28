// Задача 57: Составить частотный словарь элементов двумерного массива. Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.
// { 1, 9, 9, 0, 2, 8, 0, 9 }
// 0 встречается 2 раза 
// 1 встречается 1 раз 
// 2 встречается 1 раз 
// 8 встречается 1 раз 
// 9 встречается 3 раза
// 1, 2, 3 
// 4, 6, 1 
// 2, 1, 6
// 1 встречается 3 раза 
// 2 встречается 2 раз 
// 3 встречается 1 раз 
// 4 встречается 1 раз 
// 6 встречается 2 раза

void CountElement(int[,] array)
{
    for (int element = 0; element < 10 ; element++)
    {
        int count = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                if(array[i,j] == element)
                {
                    count ++;
                }
            }
        }
        if (count != 0) Console.WriteLine(element + " встречается " + count + " раз");
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
            array[i,j] = new Random().Next (1,10);
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
CountElement(array);
