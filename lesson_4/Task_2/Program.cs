// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Clear();
Console.WriteLine("Input random number: ");
double num = Convert.ToDouble(Console.ReadLine()!);
double sum = 0;
num = Math.Abs(num);
while(num > 0)
{

    sum += num%10;
    num = Math.Floor(num/10);     
}
Console.Write($"The sum of the digits in a number: {Math.Floor(sum)}"); //Если вдруг введут дробное число что бы грамматно отображало