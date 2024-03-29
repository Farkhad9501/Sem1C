﻿// Задача 15: Напишите программу, которая:
// 1. Принимает на вход цифру, обозначающую день недели;
// 2. Проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите цифру, обозначающую день недели: ");
int day = Convert.ToInt32(Console.ReadLine());

if (day > 0 && day < 8)
{
    if (day == 6 || day == 7) Console.WriteLine($"ДА! {day} день недели являеься выходным");
    else Console.WriteLine($"НЕТ! {day} день недели не является выходным");
}
else
{
    Console.WriteLine($"Введенная цифра выходит за диапазон дней недели. \nВведите другую цифру.");
}
