//  Задача 2:  Напишите программу, которая на вход принимает два числа и выдаёт, 
//  какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

int a = new Random().Next(1,100);
int b = new Random().Next(1,100);

// int a = 3;
// int b = 2;

if (b > a)
{
    Console.WriteLine($"Большее число b - {b}, меньшее число a - {a}");
}
else
{
    Console.WriteLine($"Большее число a - {a}, меньшее число b - {b}");
}


// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

int a1 = new Random().Next(1,100);
int b1 = new Random().Next(1,100);
int c1 = new Random().Next(1,100);

int max = a1;

if (b1 > max)
{
    max = b1;
}
if (c1 > max)
{
    max = c1;
}
Console.WriteLine($"Из трех чисел {a1}, {b1}, {c1} максимальное число - {max}");

// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, 
// является ли число чётным (делится ли оно на два без остатка).

// 4 -> да
// -3 -> нет
// 7 -> нет

int num = new Random().Next(1,100);

if (num % 2 == 0)
{
   Console.WriteLine($"Число {num} четное"); 
}
else{
   Console.WriteLine($"Число {num} не четное"); 
}

// Задача 8: Напишите программу, которая на вход принимает число (N), 
// а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

int n = new Random().Next(1,20);
int index = 0;
Console.WriteLine($"Все чётные числа от 1 до {n} :");
while (index < n )
{
    if (index % 2 == 0 )
    {
        Console.WriteLine(index);
    }
    index ++;
}



