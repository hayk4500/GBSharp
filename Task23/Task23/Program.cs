Console.WriteLine("Введите число, и мы вычислим кубы всех целых чисел до этого числа: ");
int num = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i <= num; i++)
{
    Console.Write(Math.Pow(i, 3) + "\t");
}