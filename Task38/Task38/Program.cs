Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
double[] numbers = new double[num];
double result = 0;

for (int i = 0; i < numbers.Length; i++)
{
    Random rnd = new Random();
    numbers[i] = rnd.NextDouble(); // попробуем дабл))) Как понял, возвращает значения от 0 до 1
    Console.Write(numbers[i] + "\t");
}

result = numbers[numbers.Length - 1] - numbers[0];
Console.WriteLine($"\nResult is: {result}");