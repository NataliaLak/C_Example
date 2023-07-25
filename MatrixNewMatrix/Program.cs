// Задача 49: Задайте двумерный массив. Найдите элементы, у которых оба 
//  индекса чётные, и замените эти элементы на их квадраты. 
 
// Например, изначально массив 
//  выглядел вот так: 
// 1 4 7 2 
// 5 9 2 3 
// 8 4 2 4 
 
// Новый массив будет выглядеть  
// вот так: 
// 1 4 7 2 
// 5 81 2 9 
// 8 4 2 4 
 
int[,] NewArray(int[,] array) 
{ 
    int[,] newArray = new int[array.GetLength(0), array.GetLength(1)]; 
    for (int i = 0; i < array.GetLength(0); i++) 
    { 
        for (int j = 0; j < array.GetLength(1); j++) 
        { 
            if (i % 2 == 0 & j % 2 == 0) newArray[i, j] = array[i, j] * array[i, j]; 
            else newArray[i, j] = array[i, j]; 
        } 
    } 
    return newArray; 
} 
 
 
void PrintTwoDimensionalArray(int[,] array) 
{ 
    for (int i = 0; i < array.GetLength(0); i++) 
    { 
        for (int j = 0; j < array.GetLength(1); j++) 
        { 
            Console.Write($"{array[i, j]}\t", -3); 
        } 
        Console.WriteLine(); 
    } 
} 
 
int[,] GenerateTwoDimensionalArray(int rows, int columns, int startValue, int finishValue) 
{ 
    int[,] workingArray = new int[rows, columns]; 
    for (int i = 0; i < workingArray.GetLength(0); i++) 
    { 
        for (int j = 0; j < workingArray.GetLength(1); j++) 
        { 
            workingArray[i, j] = new Random().Next(startValue, finishValue + 1); 
        } 
    } 
    return workingArray; 
} 
 
int GetInput(string text) 
{ 
    Console.Write(text); 
    return Convert.ToInt32(Console.ReadLine()); 
} 
 
int m = GetInput("Введите количество строк массива: "); 
int n = GetInput("Введите количество столбцов массива: "); 
int[,] array = GenerateTwoDimensionalArray(m, n, 1, 9); //будем от 1 до 9 
PrintTwoDimensionalArray(array); 
Console.WriteLine(); 
int[,] newArray = NewArray(array); 
PrintTwoDimensionalArray(newArray);
