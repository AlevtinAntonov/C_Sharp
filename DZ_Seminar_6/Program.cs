// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3
Console.WriteLine("Задача 41:");

Console.WriteLine("Введите сколько чисел будете вводить: ");
int lengthArray = Convert.ToInt32(Console.ReadLine());

int [] newArray = new int [lengthArray];
int result = 0;

for (int i=0; i<lengthArray; i++)
{
    Console.WriteLine($"Введите {i+1} число нажмите Enter: ");
    newArray[i] = Convert.ToInt32(Console.ReadLine());
}

Console.WriteLine("[{0}]", string.Join(", ", newArray));

void CalcPositiveNumbers (int [] collection)
{
    for(int i=0; i<collection.Length; i++)
    {
        if(collection[i]>0)
        {
            result+=1;
        }
    }
    Console.WriteLine($"В массиве найдено - {result} положительных чисел.");    
}

CalcPositiveNumbers(newArray);
Console.WriteLine();

// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
Console.WriteLine("Задача 43:");

Console.WriteLine("Введите значение b1 : и нажмите Enter ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение k1 : и нажмите Enter ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение b2 : и нажмите Enter ");
double b2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение k2 : и нажмите Enter ");
double k2 = Convert.ToDouble(Console.ReadLine());

double x = (b2 - b1) / (k1 - k2);
double y = k1 * x + b1;

Console.WriteLine($"Прямые пересекутся в точке с координатами х = {x} и y = {y}");