// 1. Напишите программу, 
// 1. которая на вход принимает два числа и проверяет, 
// 2. является ли первое число квадратом второго.

// a = 25, b = 5 -> да
// a = 2, b = 10 -> нет
// a = 9, b = -3 -> да
// a = -3 b = 9 -> нет

Console.WriteLine("Введите число 1: ");
int A = Convert.ToInt32(Console. ReadLine());
Console.WriteLine("Введите число 2: ");
int B = Convert.ToInt32(Console.ReadLine());

if (A == B * B)
{
Console.WriteLine($"{A}, квадрат {B}");
}
else
{
    Console.WriteLine($"{A}, не квадрат {B}");
}