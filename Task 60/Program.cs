/*
 Задача 60. ...Сформируйте трёхмерный массив . Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
 */

int SetNumber(string message)
{
    System.Console.Write(message);
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}
int[,,] GetMatrix(int rows, int columns, int rocol, int minValue = 10, int maxValue = 99)
{
    int[,,] matrix = new int[rows, columns, rocol];
    Random rand = new Random();
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            for (int m = 0; m < rocol; m++)
            {
                matrix[i, j, m] = rand.Next(minValue, maxValue + 1);   
            }
        }
    }
    return matrix;
}
void PrintMatrix(int[,,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int m = 0; m < matrix.GetLength(2); m++)
            {
                Console.Write($"{matrix[i, j, m]}({i},{j},{m}) ");
                
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}




Console.Clear();
int rows = SetNumber("Введите количество матриц [i]: ");
int columns = SetNumber("Введите количество строк в матрицах [j]: ");
int rocol = SetNumber("Введите количество столбцов в матрицах [m]:");
int[,,] array = GetMatrix(rows, columns, rocol, 0, 9);
PrintMatrix(array);
System.Console.WriteLine();