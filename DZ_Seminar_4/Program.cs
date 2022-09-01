// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.WriteLine("Задача 25");
int numberA = new Random().Next(1,10);
int numberB = new Random().Next(1,10);
// int numberA = 3;
// int numberB = 5;

void Exponentiate (int number, int power)
{
    double result = Math.Pow(number, power);
    Console.WriteLine($"Число А - {number} в степени B - {power} равно {result}"); 
}

Exponentiate(numberA, numberB);
Console.WriteLine();

// Задача 27: Напишите программу, которая принимает на вход число 
// и выдаёт сумму цифр в числе.

// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.WriteLine("Задача 27");

// Console.WriteLine("Введите число N: "); 
// int newnumber = Convert.ToInt32(Console.ReadLine());
int newnumber = new Random().Next(10, 10000);
void SumOfDigits(int num)
{
    int sum = 0;
    while(num != 0)
    {
        sum += num % 10;
        num /= 10;
    } 
    Console.WriteLine($"Сумма цифр числа - {newnumber} равна - {sum}");
       
}

SumOfDigits(newnumber);
Console.WriteLine();

// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19, 6, 1, 33-> [1, 2, 5, 7, 19, 6, 1, 33]

Console.WriteLine("Задача 29");
int [] array = new int[8];

void FillArray(int [] collection)
{
   for (int index = 0; index < collection.Length; index++)
   {
      collection[index] = new Random().Next(0,100);
   }
}

void PrintArray(int[] col)
{
   // for (int position = 0; position < col.Length; position++)
   // {
      // Console.Write(col[position]+ ", ");
   // }
   var str = string.Join(", ", col);
   Console.WriteLine(str);
   
}

FillArray(array);
PrintArray(array);
