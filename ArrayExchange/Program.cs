// Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]

int[] ReplaceArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = array[i] * -1;
}
return array;
}

int[] GenerateRandomArray(int elements, int start, int finish)
{
    int[] mas = new int[elements];
    for (int i = 0; i < elements; i++)
    {
        mas[i] = new Random().Next(start, finish);
    }
    return mas;
}

int[] array = GenerateRandomArray(12, -9, 9);
Console.Write($"Изначальный массив [{String.Join(",", array)}]");
int[] invertArray = ReplaceArray(array);
Console.WriteLine($"Инвертированный массив [{String.Join(",", invertArray)}]");
