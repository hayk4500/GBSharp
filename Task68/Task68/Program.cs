Console.Write("Введите число m для функции Аккермана: ");
long m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число n для функции Аккермана: ");
long n = Convert.ToInt32(Console.ReadLine());

long Accerman(long m, long n)
{
    if (m < 0 && n < 0) { Console.WriteLine("Допускаются только неотрицательные значения!"); return 0; ; }
    else if (m == 0) { return n + 1; }
    else if (m > 0 && n == 0) { return Accerman(m - 1, 1); }
    else return Accerman(m - 1, Accerman(m, n - 1));
}

long result = Accerman(m, n);
Console.WriteLine($"Результат: {result}");