Console.Write("Enter number: ");
int num = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[num];
int counter = 0;

for (int i = 0; i < numbers.Length; i++)
{
    Random rnd = new Random();
    numbers[i] = rnd.Next(100, 1000);
    if ( numbers[i] % 2 == 0 )
    {
        Console.Write(numbers[i] + "\t");
        counter++;
    }
}

Console.WriteLine($"\nКоличество чётных чисел: {counter}");