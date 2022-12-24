//Напишите программу, которая принимает на вход координаты двух точек
//и находит расстояние между ними в 2D пространстве.

int aX, aY;
int bX, bY;

Console.WriteLine("Введите координаты: ");
Console.Write("aX: ");
aX = Convert.ToInt32(Console.ReadLine());
Console.Write("aY: ");
aY = Convert.ToInt32(Console.ReadLine());
Console.Write("bX: ");
bX = Convert.ToInt32(Console.ReadLine());
Console.Write("bY: ");
bY = Convert.ToInt32(Console.ReadLine());

double resultDoub = Math.Pow(bX - aX, 2) + Math.Pow(bY - aY, 2);
resultDoub = Math.Sqrt(resultDoub);
Console.WriteLine(resultDoub);