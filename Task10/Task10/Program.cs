/*
Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
Нужно сделать через числа, без индексов строк.
 */

Console.WriteLine("Введите трёхзначное число (только не 300!)");
int num = Convert.ToInt32(Console.ReadLine());

if (num == 300) Console.WriteLine("fisting is 300 bucks♂️!!!");
if (num < 100 || num > 999) { Console.WriteLine("Ну ёмаё, писал же трёхзначное!"); Environment.Exit(0); }

int secondDigit = (num / 10) % 10;
Console.WriteLine(secondDigit);