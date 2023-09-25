/*
 Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
                Например, на выходе получается вот такой массив: 1  2   3   4

                                                                 12   13    5

                                                                 11   14    6

                                                                 10  9  8   7
 */

void FillArraySpiral(int[,] array, int n)
{
    int i = 0; 
    int j = 0;
    int Shet = 1;
    for (int e = 0; e < n * n; e++)
    {
        int m = 0;
        do 
        { 
            array[i, j++] = Shet++;
        } 
        while (++m < n - 1);
        for (m = 0; m < n - 1; m++)
        {
            array[i++, j] = Shet++;
        }
        for (m = 0; m < n - 1; m++)
        {
            array[i, j--] = Shet++;
        }
        for (m = 0; m < n - 1; m++)
        {
            array[i--, j] = Shet++;
        }
        ++i; 
        ++j;
        n = n < 2 ? 0 : n - 2;
    }
}
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] < 10)
            {
                Console.Write("0" + array[i, j]);
                Console.Write(" ");
            }
            else Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

Console.Clear();
int row = 4;
int column = 4;
int[,] matrix = new int[row, column];
FillArraySpiral(matrix, column);
PrintArray(matrix);