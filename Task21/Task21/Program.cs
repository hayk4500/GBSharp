Console.WriteLine("Введите первые координаты (x, y, z) через пробел и нажмите Enter");
int[] cord1 = Console.ReadLine().Split().Select(int.Parse).ToArray();
Console.WriteLine("Введите вторые координаты (x, y, z) через пробел и нажмите Enter");
int[] cord2 = Console.ReadLine().Split().Select(int.Parse).ToArray();

double distance = Math.Sqrt(Math.Pow(cord2[0] - cord1[0], 2) + Math.Pow(cord2[1] - cord1[1], 2) + Math.Pow(cord2[2] - cord1[2], 2)); // ULTIMATE SHITCODE!!!
Console.WriteLine("Расстояние равно: " + Math.Round(distance, 2));
