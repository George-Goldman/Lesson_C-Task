﻿// Напишите программу, которая принимает на вход трёхзначное число
// и на выходе показывает последнюю цифру.
Console.WriteLine("Введите трёхзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
int digit = number % 10;
Console.WriteLine($"Последняя цифра числа {number} равна {digit}");