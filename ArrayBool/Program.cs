int GetSumPlusOrMinus(int[] array, bool positive)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (positive)
        {
            if (array[i] > 0) sum = sum + array[i];
        }
            else
    {
        if (array[i] < 0) sum = sum + array[i];
    }
}
return sum;
}

int[] GenerateRandomArray(int elements, int start, int finish)
{
    int[] array = new int[elements];
    for (int i = 0; i < elements; i++)
    {
        array[i] = new Random().Next(start, finish + 1);
    }
    return array;
}

int[] array = GenerateRandomArray(12, -9, 9);
Console.Write($"в массиве [{String.Join(",", array)}]");
Console.WriteLine($"сумма положительных чисел равна {GetSumPlusOrMinus(array, true)}, сумма отрицательных равна {GetSumPlusOrMinus(array, false)}.");
