﻿/*
Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

5 -> 2, 4
8 -> 2, 4, 6, 8
*/

Console.WriteLine("Enter number: ");
int num = Convert.ToInt32(Console.ReadLine()); // Ввод числа
int i = 2; // Для цикла, по условиям задачи, логически

Console.WriteLine("Even numbers is: "); // Цикл
while (i < num)
{
    Console.WriteLine(i); // Печатаем в консоль следующее четное число
    i += 2; // Инкрементируем на двоечку
}