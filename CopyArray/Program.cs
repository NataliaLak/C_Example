// Задача 45: Напишите программу, которая будет создавать 
// копию заданного массива с помощью поэлементного копирования.

int [] CopyArray(int[] array)
{  
    int [] newArray = new int[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        newArray[i] =  array[i];          
    }
    return newArray;
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

int GetInput(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int elements = GetInput("Введите количество элементов массива: ");
int start = GetInput("Введите начало диапазона элементов массива: ");
int finish = GetInput("Введите конец диапазона элементов массива: ");
int[] array = GenerateRandomArray(elements, start, finish);
Console.WriteLine($"Сгенерирован массив [{String.Join(", ", array)}]");
int [] arrayCopy = CopyArray(array);
Console.WriteLine($"Копия = [{String.Join(", ", arrayCopy)}] !!");