// Задача 51: Задайте двумерный массив. Найдите сумму элементов, находящихся 
//  на главной диагонали (с индексами (0,0); (1;1) и т.д. 
// Например, задан массив: 
// 1 4 7 2 
// 5 9 2 3 
// 8 4 2 4 
// Сумма элементов главной диагонали: 1+9+2 = 12 
 
 
void ShowSum(int[,] array) 
{ 
    Console.Write("Сумма элементов главной диагонали: "); 
    int sum = 0; 
    int size = array.GetLength(0); 
    if (array.GetLength(1) < array.GetLength(0)) 
        size = array.GetLength(1); 
    for (int i = 0; i < size - 1; i++) 
    { 
        Console.Write($"{array[i, i]}+"); 
        sum = sum + array[i, i]; 
    } 
    Console.Write($"{array[size - 1, size - 1]}"); 
    sum = sum + array[size - 1, size - 1]; 
    Console.Write($" = {sum}"); 
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
ShowSum(array);