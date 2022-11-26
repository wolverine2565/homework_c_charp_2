// See https://aka.ms/new-console-template for more information
Console.WriteLine("Введите число");

var a = Console.ReadLine();
var b = Math.Abs(Convert.ToInt32(a));

while (b >= 100)
{
    b /= 10;
}

var c = b % 10;

Console.WriteLine(a + " -> " + c);