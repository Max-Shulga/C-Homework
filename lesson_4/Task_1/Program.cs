//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
Console.Clear();
Console.WriteLine("Input first number: ");
double numA = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Input second number: ");
double numB = Convert.ToDouble(Console.ReadLine());

Console.Write($"The {numA} raised to a degree of the {numB} equel:{Math.Round(Math.Pow(numA, numB), 3)}");
