// Задача 10: 
// Напишите программу, которая:
// 1. Принимает на вход трёхзначное число;
// 2. На выходе показывает вторую цифру этого числа.

// 456 --> 5
// 782 --> 8
// 918 --> 1

Console.WriteLine("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 99 && number < 1000)
{
    int result = SecondNumber(number);
    Console.WriteLine($"Второй цифрой введенного вами числа будет: {result}");
}
else
{
    System.Console.WriteLine("Вы ввели не трехзначное число. Повторите попытку...");
}

int SecondNumber(int num)
{
    int res = num / 10 % 10;
    return res;
} 
