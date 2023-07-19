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