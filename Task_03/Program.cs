// See https://aka.ms/new-console-template for more information
/*Задача 3:
Напишите программу, которая выводит третью цифру
заданного числа или сообщает, что третьей цифры нет.*/

Console.WriteLine("Введите число");

int a = Math.Abs(Convert.ToInt32(Console.ReadLine()));

if(a < 100)
{
    Console.WriteLine("Третьей цифры нет");
}

else
Console.WriteLine(a + " -> " + (a.ToString()[2]));