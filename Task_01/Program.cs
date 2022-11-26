// See https://aka.ms/new-console-template for more information
Console.WriteLine("Введите число");

var a = Math.Abs(Convert.ToInt32(Console.ReadLine()));

while (a >= 100)
{
    a /= 10;
}

var b = a % 10;

Console.WriteLine("Вторая цифра " + b);