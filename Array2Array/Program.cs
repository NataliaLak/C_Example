// Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний  
// элемент, второй и предпоследний и т.д. Результат запишите в новом массиве. 
// [1 2 3 4 5] -> 5 8 3 
// [6 7 3 6] -> 36 21 
 
 
int[] MultiplyElementsOfArray(int[] collection) 
{ 
    int newLength = collection.Length / 2; 
    if (collection.Length % 2 == 1) newLength++; 
    int[] miniArray = new int[newLength]; 
    for (int i = 0; i < collection.Length / 2; i++) 
    { 
        miniArray[i] = collection[i] * collection[collection.Length - 1 - i]; 
    } 
    if (collection.Length % 2 == 1) 
    { 
        miniArray[newLength - 1] = collection[collection.Length / 2]; 
    } 
    return miniArray; 
} 
 
int[] GenerateArray(int length, int min, int max) 
{ 
    int[] array = new int[length]; 
    for (int i = 0; i < length; i++) 
    { 
        array[i] = new Random().Next(min, max + 1); 
    } 
    return array; 
} 
 
int[] array = GenerateArray(5, -9, 10); 
Console.WriteLine($"[{String.Join(",", array)}]"); 
int [] newArray = MultiplyElementsOfArray(array); 
Console.WriteLine($"[{String.Join(",", newArray)}]");

// Сортировка Выбором O(n^2) 

/*
[45, 23, -10, 5, 3, 9, 1]
min = -10
[-10, 23, 45, 5, 3, 9, 1]
min = 1
[-10, 1, 45, 5, 3, 9, 23]
min = 3
[-10, 1, 3, 5, 45, 9, 23]
min = 5
[-10, 1, 3, 5, 45, 9, 23]
min = 9
[-10, 1, 3, 5, 9, 45, 23]
min = 23
[-10, 1, 3, 5, 9, 23, 45]
*/
void InputArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(-20, 21);  // [-20; 20]
}


int[] sortVibor(int[] array)
{
    for (int i = 0; i < array.Length; i++) // Счетчики цикла лучше всего обзывать i, j, k, m, n
    {
        int indexMin = i;
        for (int j = i; j < array.Length; j++)
        {
            if (array[j] < array[indexMin])
                indexMin = j;
        }
        if (array[indexMin] == array[i])
            continue;
        
        int temp = array[i];
        array[i] = array[indexMin];
        array[indexMin] = temp;
    }
    return array;
}


Console.Clear();
Console.Write("Введите кол-во элементов массива: ");
int n = int.Parse(Console.ReadLine()!);
int[] array = new int[n];
InputArray(array);
Console.WriteLine($"Начальный массив: [{string.Join(", ", array)}]");
Console.WriteLine($"Конечный массив: [{string.Join(", ", sortVibor(array))}]");