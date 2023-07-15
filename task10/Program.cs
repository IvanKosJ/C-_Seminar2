﻿//  Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.Write("Введите трехзначное число: ");
int number = int.Parse(Console.ReadLine());
if (number > 99 && number < 1000)
{
    int digit2 = number / 10 % 10;
Console.WriteLine($"Вторая цифра введенного числа - {digit2}");
}
else
{
    Console.WriteLine($"Введенное число не трехзначное");
}