﻿// 5. Напишите программу, 
// которая на вход принимает одно число (N), 
// а на выходе показывает все целыечисла 
// в промежутке от -N до N.
// 4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4"
// 2 -> " -2, -1, 0, 1, 2"

Console.WriteLine("Введите натуральное число");
int number = Convert.ToInt32(Console.ReadLine());
int index = -number;
while (index <= number)
{
    Console.Write(index+" ");
    index++;
}