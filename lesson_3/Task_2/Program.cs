// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.Clear();

Console.Write("Input X1 coordinates: ");
int x1 = int.Parse(Console.ReadLine()!);

Console.Write("Input Y1 coordinates: ");
int y1 = int.Parse(Console.ReadLine()!);

Console.Write("Input Z1 coordinates: ");
int z1 = int.Parse(Console.ReadLine()!);

Console.Write("Input X2 coordinates: ");
int x2 = int.Parse(Console.ReadLine()!);

Console.Write("Input Y2 coordinates: ");
int y2 = int.Parse(Console.ReadLine()!);

Console.Write("Input Z2 coordinates: ");
int z2 = int.Parse(Console.ReadLine()!);

double d = Math.Sqrt(Math.Pow(x2-x1,2) + Math.Pow(y2-y1,2) +Math.Pow(z2-z1,2));
Console.Write($"The distance between points in 3D space will be equal to:{d:f3}");

// не уверен чисто математически верная ли формула но с этим сайтом ответы совпадали)
// https://calculatorium.ru/math/distance-between-two-points-in-3d