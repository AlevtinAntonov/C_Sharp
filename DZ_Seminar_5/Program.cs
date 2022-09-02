// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

Console.WriteLine("Задача 34");

int arrayOneLength = new Random().Next(5,20);
int [] arrayOne = new int [arrayOneLength];
// int [] arrayOne = {345, 897, 568, 234};

int evenNumbersCount = 0;       //четные числа
// int oddNumbersCount = 0;     //нечетные числа

void FillArray(int [] collection)   // заполнение массива случайными положительными трёхзначными числами и печать массива
{
   for (int index = 0; index < collection.Length; index++)
   {
      collection[index] = new Random().Next(100,1000);
   }
   var str = string.Join(", ", collection);
   Console.WriteLine("[{0}]", str);
}

void PrintEvenNumbersQuantity(int[] col)    // подсчет и печать четных чисел
{
    for(int i=0; i<col.Length; i++)
    {
        if (col[i] % 2 == 0)
        {
            evenNumbersCount++; //четные числа
        }
        // else     // 
        // {
        //     oddNumbersCount++; //нечетные числа
        // }
    }
    Console.WriteLine($"В массиве {evenNumbersCount} четных");
    // Console.WriteLine($"В массиве {oddNumbersCount} нечетных чисел"); 
}

FillArray(arrayOne);
PrintEvenNumbersQuantity(arrayOne);
Console.WriteLine();

// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

Console.WriteLine("Задача 36");

int arrayTwoLength = new Random().Next(2,10);
int [] arrayTwo = new int [arrayTwoLength];
// int [] arrayTwo = {3, 7, 23, 12};

int sumNumbersOddPosition = 0;       //сумма чисел на нечетных позициях

void FillArrayTwo(int [] array_col)   // заполнение массива случайными числами и печать массива
{
   for (int index = 0; index < array_col.Length; index++)
   {
      array_col[index] = new Random().Next(-12,12);
   }
   var str = string.Join(", ", array_col);
   Console.WriteLine("[{0}]", str);
}

void PrintSumOddPosition(int[] coll)    // подсчет суммы чисел на нечетных позициях и печать 
{
    for(int i=1; i<coll.Length; i+=2)
    {
        sumNumbersOddPosition+= coll[i];
    }
    Console.WriteLine($"В массиве сумма чисел на нечетных позициях = {sumNumbersOddPosition}");
}
FillArrayTwo(arrayTwo);
PrintSumOddPosition(arrayTwo);
Console.WriteLine();

// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76
Console.WriteLine("Задача 38");

Random rand = new Random();
int arrayThreeLength = rand.Next(2,8);
double [] arrayThree = new double [arrayThreeLength];

void FillArrayThree(double [] array_three)   // заполнение массива случайными вещественными числами и печать массива
{
   for (int index = 0; index < array_three.Length; index++)
   {
      
      array_three[index] = Math.Round(rand.Next(-100, 100) + rand.NextDouble(), 3) ;
   }
   var str = string.Join(", ", array_three);
   Console.WriteLine("[{0}]", str);
}

void PrintMaxMinNumber(double [] array_3) // поиск макимального и минимального значение и расчет разницы между ними
{
    double max_number = array_3[0];
    double min_number = array_3[0];
    for (int i = 0; i < array_3.Length; i++)
    {
        if (array_3[i] > max_number)
        {
            max_number = array_3[i];
        }
        if (array_3[i] < min_number)
        {
            min_number = array_3[i];
        }
    }
    double diff = Math.Round(max_number - min_number, 3);
    Console.WriteLine($"Разница между максимумом {max_number} и минимумом {min_number} = {diff} "); 
}

FillArrayThree(arrayThree);
PrintMaxMinNumber(arrayThree);
Console.WriteLine();