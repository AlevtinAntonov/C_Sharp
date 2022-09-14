// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int[,] matrixA = new int[new Random().Next(2, 5), new Random().Next(2,5)];
int[,] matrixB = new int[new Random().Next(2, 5), new Random().Next(2, 5)];
// int [,] matrixA = new int[2, 2];
// int [,] matrixB = new int[2, 2];

Console.WriteLine("Первоначальный двумерный массив A:");
FillArray(matrixA);
PrintArray(matrixA);

Console.WriteLine("Первоначальный двумерный массив B:");
FillArray(matrixB);
PrintArray(matrixB);

if (matrixA.GetLength(1) == matrixB.GetLength(0))
{
    int [,] matrixResult = new int[matrixA.GetLength(0), matrixB.GetLength(1)];

    for (int i = 0; i < matrixA.GetLength(0); i++)
    {
        for (int j = 0; j < matrixB.GetLength(1); j++)
    {
            for (int k = 0; k < matrixB.GetLength(0); k++)
            {
                matrixResult[i,j] += matrixA[i,k] * matrixB[k,j];
            }
        }
    }
    Console.WriteLine("Результат умножения массива А на массив В: ");
    Console.WriteLine();
    PrintArray(matrixResult);
}
else
    Console.WriteLine("Невозможно выполнить умножение матриц, так как число столбцов первой матрицы не совпадает с числом строк второй матрицы.");

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    }
}

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