// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

int num = new Random().Next(100,1000);
int second = ((num - num / 100 * 100) - (num % 10)) / 10 ;

Console.WriteLine("Задача 10");
Console.WriteLine($"В трехзначном числе - {num} вторая цифра - {second}");

// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6

int number = new Random().Next(1,100000000);
int number_length = number.ToString().Length;

Console.WriteLine("Задача 13");
if (number_length < 3)
{
    Console.WriteLine($"В числе - {number} третьей цифры нет");
}
else
{
    string str = number.ToString();
    int[] array = new int[str.Length];
    int i = 0;
    while(i < str.Length)
    {
        array[i] = int.Parse(str[i].ToString());
        i++;
    }
    
    Console.WriteLine($"В числе - {number} третья цифра - {array[2]}");
}

// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
// и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

int day_of_week = new Random().Next(1,8);
// int day_of_week = 7;

Console.WriteLine("Задача 15");
if (day_of_week == 6 || day_of_week == 7)
{
    Console.WriteLine($"{day_of_week} день недели является выходным");
}
else
{
    Console.WriteLine($"{day_of_week} день недели - рабочий день");
}