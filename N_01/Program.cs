﻿//Задача 8: Напишите программу, которая на вход принимает число (N), 
// а на выходе показывает все чётные числа от 1 до N.
// 
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8



Console.Write("Введите число N: ");

int number=Convert.ToInt32(Console.ReadLine());
if (number <0)
{
    number = number * (-1);
}

int a = 1;

while (a <= number)
{   
    if (a %2 == 0)

    Console.WriteLine(a);
    a+=1;
}
