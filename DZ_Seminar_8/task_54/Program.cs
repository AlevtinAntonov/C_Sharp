// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2


int[,] array = new int[new Random().Next(1, 10), new Random().Next(1, 10)];
// int[,] array = new int[3, 3];

Console.WriteLine("Первоначальный двумерный массив:");
Console.WriteLine();
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i, j] = new Random().Next(0, 10);
    }
}
PrintArray(array);
Console.WriteLine("Новый массив, строки отсортированы по убыванию:");
Console.WriteLine();

int[] row = new int[array.GetLength(1)];

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        row[j] = array[i, j];
    }
    // BubbleSort(row); // 1 вариант
    row = row.OrderByDescending(c => c).ToArray(); // 2 вариант
    foreach(int value in row)
    {
        Console.Write(value + "\t");
    }
    Console.WriteLine();
    
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

// void BubbleSort(int[] inArray) // 1 вариант
// {
//     for (int i = 0; i < inArray.Length; i++)
//         for (int j = 0; j < inArray.Length-1; j++)
//             if (inArray[j] < inArray[j + 1])
//             {
//                 int temp = inArray[j];
//                 inArray[j] = inArray[j + 1];
//                 inArray[j + 1] = temp;
//             }  
// }
