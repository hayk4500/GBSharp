Console.WriteLine("Введите числа через пробел:");
int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
int positiveNumCounter = 0;

for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] > 0) positiveNumCounter++;
}

Console.WriteLine($"Количество введенных положительных чисел (больше нуля): {positiveNumCounter}");