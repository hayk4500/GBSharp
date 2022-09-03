using System.Runtime.ExceptionServices;

Console.Write("Введите размер X: ");
int sizeX = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите размер Y: ");
int sizeY = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите размер Z: ");
int sizeZ = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

int[,,] array3D = new int[sizeX, sizeY, sizeZ];
int[] tempNumForArray = new int[sizeX * sizeY * sizeZ];

for (int i = 0; i < tempNumForArray.Length; i++)
{
    tempNumForArray[i] = new Random().Next(10, 100);

    if (i > 0)
    {
        for (int j = 0; j < i; j++)
        {
            while (tempNumForArray[i] == tempNumForArray[j])
            {
                tempNumForArray[i] = new Random().Next(10, 100);
            }

        }
    }
}

int tempIndex = 0;

for (int i = 0; i < sizeX; i++)
{
    for (int j = 0; j < sizeY; j++)
    {
        for (int k = 0; k < sizeZ; k++)
        {
            array3D[i, j, k] = tempNumForArray[tempIndex];
            Console.Write($"{array3D[i, j, k]} ({i},{j},{k}) \t");
            tempIndex++;
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}