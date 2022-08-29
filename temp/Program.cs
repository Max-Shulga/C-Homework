// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int GetRow()
{
    Console.Write("Input number of rows for Multidimensional Arrays: ");
    int row = int.Parse(Console.ReadLine()!);
    while(row < 1)
    {
        Console.Write("Invalid digit, please enter the correct digit: ");
        int temp = int.Parse(Console.ReadLine()!);
        row = temp;
    }
    return row;
}
//не нашел как и вообще можно ли через return вернуть 2 и более значений
int GetColum()
{
    Console.Write("Input number of rows for Multidimensional Arrays: ");
    int colum = int.Parse(Console.ReadLine()!);
    while(colum < 1)
    {
        Console.Write("Invalid digit, please enter the correct digit: ");
        int temp = int.Parse(Console.ReadLine()!);
        colum = temp;
    }
    return colum;
}

int GetStartNum()
{
    Console.Write("Input numerical start of range: ");
    int start = int.Parse(Console.ReadLine()!);
    return start;
}

int GetEndNum()
{
    Console.Write("Input number of rows for Multidimensional Arrays: ");
    int end = int.Parse(Console.ReadLine()!);
    return end;
}

int[,] CreateMulti(int row, int colum, int minNum, int MaxNum)
{
    int[,] multi = new int[row, colum];
    for (int i = 0; i < multi.GetLength(0); i++)
    {
        for (int j = 0; j < multi.GetLength(1); j++)
        {
            multi[i,j] = new Random().Next(minNum, MaxNum+1);
        }
    }
    return multi;
}

double [,] CreateMultiDouble(int row, int colum, int minNum, int MaxNum)
{
    double [,] multi = new double[row, colum];
    for (int i = 0; i < multi.GetLength(0); i++)
    {
        for (int j = 0; j < multi.GetLength(1); j++)
        {
            Random num = new Random();
            Random num2 = new Random();
            double digit = Convert.ToDouble(num.Next(minNum, MaxNum+1));
            digit = digit/num2.Next(2,9);
            multi[i,j] = digit;
        }
    }
    return multi;
}

void PrintMulti (int [,] multi)
{
    for (int i = 0; i < multi.GetLength(0); i++)
    {
        for (int j = 0; j < multi.GetLength(1); j++)
        {
            Console.Write($"{multi[i, j]}\t");
        }
        Console.WriteLine();
    }

}
void PrintMultiDouble (double [,] multi)
{
    for (int i = 0; i < multi.GetLength(0); i++)
    {
        for (int j = 0; j < multi.GetLength(1); j++)
        {
            Console.Write($"{multi[i, j] :f2}\t ");
        }
        Console.WriteLine();
    }
}


double [,] multi = CreateMultiDouble(GetRow(), GetColum(), GetStartNum(), GetEndNum());

PrintMultiDouble(multi);

