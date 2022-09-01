// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int GetDigitCondition(string message)
{
    Console.WriteLine(message);
    int colum = int.Parse(Console.ReadLine()!);
    while (colum < 1)
    {
        Console.Write("Invalid digit, please enter the correct digit: ");
        int temp = int.Parse(Console.ReadLine()!);
        colum = temp;
    }
    return colum;
}

int GetDigit(string message)
{
    Console.WriteLine(message);
    int start = int.Parse(Console.ReadLine()!);
    return start;
}

int[,] CreateMulti(int row, int colum, int minNum, int MaxNum)
{
    int[,] multi = new int[row, colum];
    for (int i = 0; i < multi.GetLength(0); i++)
    {
        for (int j = 0; j < multi.GetLength(1); j++)
        {
            multi[i, j] = new Random().Next(minNum, MaxNum + 1);
        }
    }
    return multi;
}

void PrintMulti(int[,] multi)
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

void AverageInColum(int[,] multi)
{
    double sum = 0;
    for (int i = 0; i < multi.GetLength(1); i++) //перебор стобцов
    {
        for (int j = 0; j < multi.GetLength(0); j++) //строк
        {
            sum += multi[j, i]; // считает сумму значений в стобце
        }
        Console.WriteLine($" in {i + 1} colum average is: {sum / multi.GetLength(0)}"); //делим на количество строк
        sum = 0;
    }
}

int[,] matrix = CreateMulti(
    GetDigitCondition("Input number of row for Multidimensional Arrays:  "),
    GetDigitCondition("\nInput number of colums for Multidimensional Arrays: "),
    GetDigit("\nInput numerical start of range: "),
    GetDigit("\nInput numerical end of range: ")
);
PrintMulti(matrix);
AverageInColum(matrix);
