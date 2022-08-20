Console.WriteLine("Введите числа через пробел и нажмите Enter");
int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

Console.WriteLine("Окей! Вы ввели следующие числа: ");
for (int i = 0; i < numbers.Length; i++)
{
    Console.Write("| " + numbers[i] + " |");
}