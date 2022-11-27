// See https://aka.ms/new-console-template for more information
/*Задача 4:
Напишите программу, которая принимает на вход цифру,
обозначающую день недели, и проверяет, является ли этот день выходным.*/

Console.WriteLine("Введите число");
int a = Math.Abs(Convert.ToInt32(Console.ReadLine()));

if ((a>0) && (a<=5))
{
    Console.WriteLine("Рабочий день");
}
else 
    if ((a == 6) ||  (a == 7))
    {
        Console.WriteLine("Выходной день");
    }
else 
Console.WriteLine("Неверное значение");