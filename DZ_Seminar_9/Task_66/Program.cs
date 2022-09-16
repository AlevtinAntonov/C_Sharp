// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.WriteLine("Введите число M: "); 
int M = Convert.ToInt32(Console.ReadLine()); 
Console.WriteLine("Введите число N: "); 
int N = Convert.ToInt32(Console.ReadLine()); 

int SumOfNaturalNumbersInRange (int M,int N) 
{ 
    if(M<=N) return (M + SumOfNaturalNumbersInRange(M+1,N));
    else return 0; 
} 

if (M <N) Console.WriteLine($"Сумма натуральных элементов в промежутке от {M} до {N} -> {SumOfNaturalNumbersInRange(M,N)}");
else Console.WriteLine($"Ошибка! Второе число M: {M} больше первого числа N:  {N}");