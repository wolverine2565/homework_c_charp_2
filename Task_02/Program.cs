// See https://aka.ms/new-console-template for more information

Random rnd = new Random();
 
int a = rnd.Next(100, 999);
 
Console.WriteLine(a); 

int b = int.Parse(a.ToString().Remove(1,1));
Console.WriteLine(a + " -> " + b);