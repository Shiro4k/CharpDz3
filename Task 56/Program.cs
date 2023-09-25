/*
 Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
 */

void PrintArr(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.WriteLine($"Строка {i} = {arr[i]}");
    }
}
int[,] GetMatrix(int rows, int columns, int minValue = 10, int maxValue = 99)
{
    int[,] matrix = new int[rows, columns];
    Random rand = new Random();
    for (int i = 0; i < rows; i++)
    {
        for (int l = 0; l < columns; l++)
            matrix[i, l] = rand.Next(minValue, maxValue + 1);
    }
    return matrix;
}
void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int l = 0; l < matrix.GetLength(1); l++)
            Console.Write($"{matrix[i, l]} ");
        Console.WriteLine();
    }
}
int[] SumLineMatrix(int[,] matrix)
{
    int[] arr = new int[matrix.GetLength(0)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sum += matrix[i, j];           
        }
        arr[i] = sum;
    }
    return arr;
}





Console.Clear();
int rows = 4;
int columns = 9;
int[,] array = GetMatrix(rows, columns, 0, 9);
PrintMatrix(array);
System.Console.WriteLine();
int[] arr = SumLineMatrix(array);
PrintArr(arr);
