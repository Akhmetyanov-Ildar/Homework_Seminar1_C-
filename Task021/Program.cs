// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53
Console.WriteLine("Введите координаты  1 точки");
Console.WriteLine("x1: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("y1: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("z1: ");
int z1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты  2 точки");
Console.WriteLine("x2: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("y2: ");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("z2: ");
int z2 = Convert.ToInt32(Console.ReadLine());
double result = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));
result = Math.Round(result, 2);
Console.WriteLine(result);