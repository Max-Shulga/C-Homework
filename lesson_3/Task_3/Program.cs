// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.Clear();

Console.Write("Input any positive integer: ");
int numb = int.Parse(Console.ReadLine()!);
int count = 1;


while(numb <= 1) 
{
    Console.Write("Wrong number try again: ");
    int temp = int.Parse(Console.ReadLine()!);
    numb = temp;
}
Console.Write(numb+ "--->");
while(count <= numb)
{
    Console.Write($"{Math.Pow(count, 3)}, ");
    count++;
}
