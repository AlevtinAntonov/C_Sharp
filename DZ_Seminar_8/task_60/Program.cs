// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)


int[,,] arr = new int[2, 2, 2];

static IEnumerable<int> UniqueRandomNumbers(int from, int to)
{
    Random rand = new Random();
    int[] values = Enumerable.Range(from, to).ToArray();
    int i = values.Length;
    while (i > 0)
    {
        int j = rand.Next(i--);
        yield return values[j];
 
        (values[i], values[j]) = (values[j], values[i]);
    }
}
IEnumerator<int> iterator = UniqueRandomNumbers(10, 92).GetEnumerator();
 
for (int i = 0; i < arr.GetLength(0); i++)
for (int j = 0; j < arr.GetLength(1); j++)
for (int k = 0; k < arr.GetLength(2); k++)
{
    if (!iterator.MoveNext())
    {
        Console.WriteLine("Уникальные числа закончились!");
        return;
    }
 
    arr[i, j, k] = iterator.Current;
}

PrintArray(arr);
void PrintArray(int[,,] printArray)
{
    for (int a = 0; a < printArray.GetLength(0); a++)
    for (int b = 0; b < printArray.GetLength(1); b++)
        {
            for (int c = 0; c < printArray.GetLength(2); c++)
            {
                Console.Write($"{printArray[a, b, c]} ({a}, {b}, {c})" + "\t");
            }
        Console.WriteLine();
        }
    
}
