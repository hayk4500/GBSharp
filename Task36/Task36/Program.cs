Console.Write("Enter number: ");
int num = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[num];
long sum = 0;

for (int i = 0; i < numbers.Length; i++)
{
    Random rnd = new Random();
    numbers[i] = rnd.Next(-99999, 100000);
    if (i % 2 != 0)
    {
        Console.Write(numbers[i] + "\t");
        sum += numbers[i];
    }
}

Console.WriteLine($"\nСумма всех чисел под нечётными индексами: {sum}");