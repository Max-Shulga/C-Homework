// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int sum = 0;
int GetSum(int a, int b)
{
    if (a == b)
        return sum += a;
    return sum += a + GetSum(a + 1, b);
}

Console.Write(GetSum(4, 8));
