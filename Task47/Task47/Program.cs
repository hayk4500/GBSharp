Console.WriteLine("Укажите количество строк и столбцов в двумерном массиве:");
int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());
double[,] realArray = new double[m, n];
Console.WriteLine();

for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        realArray[i, j] = (new Random().NextDouble() * 15);
        Console.Write(Math.Round(realArray[i, j], 2) + "\t");
    }
    Console.WriteLine();
}