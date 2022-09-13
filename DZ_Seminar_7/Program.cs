// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

Console.WriteLine("Задача 47");
Console.Write("Введите количество строк ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов ");
int n = Convert.ToInt32(Console.ReadLine());

double[,] matrix = new double[m, n];
Random rand = new Random();

void FillArray(double[,] array)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = Math.Round(rand.Next(-10, 10) + rand.NextDouble(), 1);
            Console.Write(matrix[i, j] + "\t");
        }
        Console.WriteLine();
    }
}
FillArray(matrix);
Console.WriteLine();


// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

Console.WriteLine("Задача 50");
Console.Write("Введите строку ");
int row = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите столбец ");
int column = Convert.ToInt32(Console.ReadLine());

int rows = new Random().Next(1, 10);
int columns = new Random().Next(1, 10);

int[,] arrayRandom = new int[rows, columns];


void FillArrayRandom(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 11);
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
}
FillArrayRandom(arrayRandom);


if (row > arrayRandom.GetLength(0))
{
    Console.WriteLine($"В массиве нет строки номер {row}");
}
else if (column > arrayRandom.GetLength(1))
{
    Console.WriteLine($"В массиве нет столбца  номер {column}");
}
else 
    Console.WriteLine($"В строке  {row} и столбце {column} значение элемента : {arrayRandom[row-1, column-1]} ");

Console.WriteLine();

// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
Console.WriteLine("Задача 52");

int rowsArray = new Random().Next(1, 10);
int columnsArray = new Random().Next(1, 10);

int[,] matrixArray = new int[rowsArray, columnsArray];
double [] columnSum = new double[columnsArray];

for (int i = 0; i < rowsArray; i++)
{
    for (int j = 0; j < columnsArray; j++)
    {
        matrixArray[i, j] = new Random().Next(0, 11);
        columnSum[j]+=matrixArray[i,j]; 
        Console.Write(matrixArray[i, j] + "\t");
    }
    
    Console.WriteLine();
}

double [] averageColumn = new double[columnSum.Length];
for (int i = 0; i < columnSum.Length; i++)
{
    averageColumn[i]= Math.Round(columnSum[i]/rowsArray, 2); 
}
Console.WriteLine("Среднее арифметческое столбцов: ");
Console.WriteLine(string.Join("\t ", averageColumn));