/*
Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

4 -> да
-3 -> нет
7 -> нет
*/

Console.WriteLine("Enter number: ");
int num = Convert.ToInt32(Console.ReadLine()); // Ввод числа

if ((num % 2) == 0) // Проверка делимости нацело на два
{
    Console.WriteLine("Even"); // Чётное
}
else { Console.WriteLine("Odd"); } // Нечётное