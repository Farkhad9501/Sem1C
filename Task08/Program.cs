﻿// 8: Напишите программу, 
// которая на вход принимает число (N), 
// а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.WriteLine("Введите натуральное число: ");
int a = Convert.ToInt32(Console.ReadLine());
int x =1;
if (a > 0)
{
    Console.WriteLine($"Четные числа от 1 до {a}: ");
    while (x < a)
    {
        Console.Write(x+1+", ");
        x+=2;
    }
}
else
{
    System.Console.WriteLine("Вы ввели не натуральное число. Введите НАТУРАЛЬНОЕ число!");
}


