// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

int[,] array = new int[new Random().Next(1, 10), new Random().Next(1, 10)];
// int[,] array = new int[4, 4];

int [] arrayRowSum = new int[array.GetLength(0)];


Console.WriteLine("Прямоугольный двумерный массив:");
Console.WriteLine();

for (int i = 0; i < array.GetLength(0); i++)
{
    int sum = 0;
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i, j] = new Random().Next(0, 10);
        sum += array[i,j];
    }
    arrayRowSum[i] = sum;
}

PrintArray(array);
Console.WriteLine();

int indexMin = Array.IndexOf( arrayRowSum, arrayRowSum.Min() );

Console.WriteLine( $"Номер строки с наименьшей суммой элементов: {indexMin+1} - строка, сумма = {arrayRowSum[indexMin]}" );

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

Console.WriteLine();