Console.WriteLine("Сейчас мы попробуем найти точку пересечения двух прямых, которые заданы уравнением y = k1 * x + b1, y = k2 * x + b2");

Console.Write("Введите b1: ");
int b1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите k1: ");
int k1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите b2: ");
int b2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите k2: ");
int k2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Ок! Секунду, щас посчитаем!");
float x = (float) (b2 - b1) / (k1 - k2);
float y = (float) k1 * (b2 - b1) / (k1 - k2) + b1;
Console.WriteLine("Готово!");

Console.WriteLine($"Точкой пересечения данных двух прямых является координата ({x};{y})");