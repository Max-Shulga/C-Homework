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
    Console.Write("Input number of colums for Multidimensional Arrays: ");
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
    Console.Write("Input numerical end of range: ");
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

void AverageInColum(int [,] multi)
{
    double sum = 0;
    for (int i = 0; i < multi.GetLength(0); i++)
    {
        for (int j = 0; j < multi.GetLength(1); j++)
        {
            sum += multi[j,i]; 
        }
    Console.WriteLine($"in {i+1} colum average is: {sum/multi.GetLength(1)}");
    sum = 0;
    }
}

int[,] matrix = CreateMulti(GetRow(),GetColum(),GetStartNum(),GetEndNum());
PrintMulti(matrix);
AverageInColum(matrix);