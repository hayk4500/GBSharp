Console.Write("Строк первой матрицы: ");
int rowsForMatrixA = Convert.ToInt32(Console.ReadLine());
Console.Write("Столбцов первой матрицы: ");
int columnsForMatrixA = Convert.ToInt32(Console.ReadLine());

Console.Write("Строк второй матрицы: ");
int rowsForMatrixB = Convert.ToInt32(Console.ReadLine());
Console.Write("Столбцов второй матрицы: ");
int columnsForMatrixB = Convert.ToInt32(Console.ReadLine());

int[,] matrixA = new int[rowsForMatrixA, columnsForMatrixA];
int[,] matrixB = new int[rowsForMatrixB, columnsForMatrixB];
int[,] matrixC = new int[rowsForMatrixA, columnsForMatrixB];

Console.WriteLine("Матрица A:");
for (int row = 0; row < rowsForMatrixA; row++)
{
    for (int column = 0; column < columnsForMatrixA; column++)
    {
        matrixA[row, column] = new Random().Next(11);
        Console.Write(matrixA[row, column] + "\t");
    }
    Console.WriteLine();
}

Console.WriteLine();

Console.WriteLine("Матрица B:");
for (int row = 0; row < rowsForMatrixB; row++)
{
    for (int column = 0; column < columnsForMatrixB; column++)
    {
        matrixB[row, column] = new Random().Next(11);
        Console.Write(matrixB[row, column] + "\t");
    }
    Console.WriteLine();
}

if (columnsForMatrixA != rowsForMatrixB)
{
    Console.WriteLine("Число столбцов первой матрицы не равно числу строк второй! Умножение невозможно!"); Environment.Exit(0);
}

Console.WriteLine();
Console.WriteLine("Умножение матриц: ");
for (int row = 0; row < rowsForMatrixA; row++)
{
    for (int column = 0; column < columnsForMatrixB; column++)
    {
        for (int n = 0; n < rowsForMatrixB; n++)
        {
            matrixC[row, column] += matrixA[row, n] * matrixB[n, column];
        }
        Console.Write(matrixC[row, column] + "\t");
    }
    Console.WriteLine();
}