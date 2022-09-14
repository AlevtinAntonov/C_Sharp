// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

int matrixRow = 4;
int matrixColumn = 4;
// int matrixRow = 6;
// int matrixColumn = 5;
int[,] matrix = new int[matrixRow, matrixColumn];
 
int row = 0;
int col = 0;
int dx = 1;
int dy = 0;
int dirChanges = 0;
int visits = matrixColumn;
 
for (int i = 0; i < matrix.Length; i++) 
{
    matrix[row, col] = i + 1;
    if (--visits == 0) 
    {
        visits = matrixColumn * (dirChanges %2) + matrixRow * ((dirChanges + 1) %2) - (dirChanges/2 - 1) - 2;
        int temp = dx;
        dx = -dy;
        dy = temp;
        dirChanges++;
    }
    col += dx;
    row += dy;
}

Console.WriteLine($"Спирально заполненный массив размером {matrixRow} на {matrixColumn}");
Console.WriteLine();

PrintArray(matrix);

void PrintArray(int[,] printArray)
{
    for (int a = 0; a < printArray.GetLength(0); a++)
    {
        for (int b = 0; b < printArray.GetLength(1); b++)
        {
            Console.Write(printArray[a, b] + "\t");
        }
        Console.WriteLine();
    }
}