Console.Write("Строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] matrix = new int[rows, columns];

Console.WriteLine("Матрица:");
for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < columns; j++)
    {
        matrix[i, j] = new Random().Next(11);
        Console.Write(matrix[i, j] + "\t");
    }
    Console.WriteLine();
}

int[] rowsSum = new int[columns];

for (int i = 0; i < rows; i++)
{
    int sum = 0;
    int j;
    for (j = 0; j < columns; j++)
    {
        sum += matrix[i, j];
    }
    rowsSum[i] = sum;
    
}

int minRowIndex = Array.IndexOf(rowsSum, rowsSum.Min());
Console.WriteLine($"Строка с минимальным значением суммы её элементов: {minRowIndex + 1}");