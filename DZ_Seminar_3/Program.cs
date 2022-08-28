// Задача 19

// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет

// 12821 -> да

// 23432 -> да

Console.WriteLine("Задача 19");

int number = new Random().Next(10000,100000);
// int number = 23432;

string name = number.ToString();
string reverse = string.Empty;
            
for (int i = name.Length - 1; i >= 0; i--)
{
    reverse += name[i];
}

if (name == reverse)
{
    Console.WriteLine($"Число {number} является палиндромом");
}
else
{
    Console.WriteLine($"Число {number} не является палиндромом");
}



// Задача 21

// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("Задача 21");

Console.WriteLine("Введите хa:"); 
int xa = Convert.ToInt32(Console.ReadLine()); 
Console.WriteLine("Введите ya:"); 
int ya = Convert.ToInt32(Console.ReadLine()); 
Console.WriteLine("Введите za:"); 
int za = Convert.ToInt32(Console.ReadLine()); 
Console.WriteLine("Введите хb:"); 
int xb = Convert.ToInt32(Console.ReadLine()); 
Console.WriteLine("Введите yb:"); 
int yb = Convert.ToInt32(Console.ReadLine()); 
Console.WriteLine("Введите zb:"); 
int zb = Convert.ToInt32(Console.ReadLine()); 

double d = Math.Sqrt(Math.Pow(xb -xa,2) + Math.Pow(yb - ya,2) + Math.Pow(zb - za,2)); 

Console.WriteLine($"Длина отрезка - {d}"); 



// Задача 23

// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125
Console.WriteLine("Задача 23");
Console.WriteLine("Введите число N: "); 
int num = Convert.ToInt32(Console.ReadLine()); 

for (int count = 1; count<=num; count++) 
{ 
    double cube = Math.Pow(count, 3); 
    Console.WriteLine(cube);
} 