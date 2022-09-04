Console.Write("Введите первое число: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int N = Convert.ToInt32(Console.ReadLine());
int sum = 0;

int Numbers(int M, int N)
{
    if (M > N) { return sum; }
    else if (M < 1)
    {
        for (int i = M; M < 1; M++) { }
        return Numbers(M, N);
    }
    else
    {
        sum += M;
        M++;
        return Numbers(M, N);
    }
}

Numbers(M, N);
Console.WriteLine($"Сумма всех натуральных элементов равана {sum}");