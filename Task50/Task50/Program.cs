Console.WriteLine("Укажите количество строк и столбцов в двумерном массиве. А потом мы попробуем найти элемент массива по его индексу");
int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());
double[,] realArray = new double[m, n];

Console.WriteLine();

for (int k = 1; k < n + 1; k++)
{
    Console.Write(k + "\t");
}

Console.WriteLine();

for (int k = 1; k < n + 1; k++)
{
    Console.Write("————————");
}

Console.WriteLine();

for (int i = 0, k = 1; i < m; i++, k++)
{
    for (int j = 0; j < n; j++)
    {
        realArray[i, j] = (new Random().NextDouble() * 15);
        Console.Write(Math.Round(realArray[i, j], 2) + "\t");
    }
    Console.Write("|" + k);
    Console.WriteLine();
}
Console.WriteLine();

Console.WriteLine("Окей! А теперь введите индекс и мы покажем вам значение этого элемента (строку и столбец).");
int row = Convert.ToInt32(Console.ReadLine());
int column = Convert.ToInt32(Console.ReadLine());

if (row <= m && column <= n)
{
    Console.WriteLine($"Точное неокруглённое значение элемента в позиции ({row};{column}) : {realArray[row-1, column-1]} ");
}
else
{
    Console.WriteLine("Куда прёшь то?! Такого элемента не было в массиве!");
}