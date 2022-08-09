/*
 Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
 */

Console.WriteLine("Введи день недели: ");
int dayNumber = Convert.ToInt32(Console.ReadLine());

if (dayNumber == 6 || dayNumber == 7) { Console.WriteLine("Выходной? Да, отдыхай!"); }
else if (dayNumber > 7) { Console.WriteLine($"Сынок, ты на какой планете живёшь и в какой системе, что у тебя аж {dayNumber} дней в неделе?!"); }
else if (dayNumber < 1) { Console.WriteLine("Ты дурак?"); }
else { Console.WriteLine("Выходной? Нет! Дуй работать!"); }