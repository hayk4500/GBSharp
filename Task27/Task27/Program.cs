Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int length = Convert.ToString(num).Length;
int result = 0, temp;

for (int k = 0; k < length; k++)
{
    temp = num % 10;
    result += temp;
    num /= 10;
}

Console.WriteLine($"Сумма всех цифр в числе: {result}");


//Можно попробовать решить через цикл while и без использования метода String.Length
//  while (num > 0)
//  {
//    temp = num % 10;
//    result += temp;
//    num /= 10;
//}

//Console.WriteLine($"Сумма всех цифр в числе: {result}");