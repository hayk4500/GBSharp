Console.Write("Введите число: ");
int _decimal = Convert.ToInt32(Console.ReadLine());

string[] _binary = new string[_decimal];
int i = 0;

while (_decimal > 0)
{
    _binary[i] = Convert.ToString(_decimal % 2);
    _decimal /= 2;
    i++;
}

Array.Reverse(_binary);
Console.WriteLine($"В двоичной системе: {String.Join((char) 0, _binary)}");