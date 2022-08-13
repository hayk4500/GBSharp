Console.WriteLine("Введите пятизначное число: ");
string numbers = Console.ReadLine();

if (numbers == new string(numbers.Reverse().ToArray()))
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("Да");
}
else
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Нет");
}