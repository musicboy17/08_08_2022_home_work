﻿// Задача 2: Напишите программу, которая на вход принимает два числа и 
// выдаёт, какое число большее, а какое меньшее.


Console.Write("Введите первое число N1: ");
int number1=Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число N2: ");
int number2=Convert.ToInt32(Console.ReadLine());

int max = number1;
if (number2 > max) 
{
    max = number2;
}
Console.WriteLine("Большее число " + max);
