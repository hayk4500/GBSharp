/*
Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3
*/
Console.WriteLine("Enter the first number:"); 
int num1 = Convert.ToInt32(Console.ReadLine()); // Ввод первого числа

Console.WriteLine("Enter the second number:"); 
int num2 = Convert.ToInt32(Console.ReadLine()); // Ввод второго числа

int max = Math.Max(num1, num2); // Математическая функция нахождения максимума
int min = Math.Min(num1, num2); // Математическая функция нахождения минимума
Console.WriteLine("The max number is: " + max); // Вывод результата на экран
Console.WriteLine("The min number is: " + min); // Вывод результата на экран