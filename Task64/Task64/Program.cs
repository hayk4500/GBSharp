Console.Write("Введите первое число: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int N = Convert.ToInt32(Console.ReadLine());

void Numbers(int M, int N)
{
    if (M > N) { Console.WriteLine(); }
    else if (M < 1)
    {
        for (int i = M; M < 1; M++) { }
        Numbers(M, N);
    }
    else
    {
        Console.Write(M + "\t");
        M++;
        Numbers(M, N);
    }
}

Numbers(M, N);