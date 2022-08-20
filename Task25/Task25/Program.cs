Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите степень: ");
int pow = Convert.ToInt32(Console.ReadLine());
int numtest = num, powtest = pow;
double result = 1;

for (int i = 1; i <= pow; i++)
{
    result *= num;
}

Console.WriteLine("Result is: " + result);

Console.Write("Проверка правильности цикла: ");
double res = Math.Pow(numtest, powtest);
Console.WriteLine(res);