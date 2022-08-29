// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

Console.Clear();

int GetRow()
{
    Console.Write("Input the value of the row to search in the array: ");
    int row = int.Parse(Console.ReadLine()!);
    while(row < 0)
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
    Console.Write("Input the value of the colum to search in the array: ");
    int colum = int.Parse(Console.ReadLine()!);
    while(colum < 0)
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
    Console.Write("Input numerical end of range: : ");
    int end = int.Parse(Console.ReadLine()!);
    return end;
}

double [,] CreateMultiDouble(int minNum, int MaxNum)
{
    double [,] multi = new double[10, 10];
    for (int i = 0; i < multi.GetLength(0); i++)
    {
        for (int j = 0; j < multi.GetLength(1); j++)
        {
            Random digit = new Random();
            double number = digit.NextDouble()*(MaxNum - minNum) + minNum;
            multi[i,j] = number;
        }
    
    }
    return multi;
}

void PrintMultiDouble (double [,] multi)
{
    for (int i = 0; i < multi.GetLength(0); i++)
    {
        for (int j = 0; j < multi.GetLength(1); j++)
        {
            if(multi[i,j] == Math.Round(multi[i,j]))
            {
                Console.Write($"{multi[i, j]}\t ");
            }
            else                                   
            {                                                     
               Console.Write($"{multi[i, j]:f2}\t ");
            }
        }
        Console.WriteLine();
    }
}

void FindValue(double [,] multi, int row, int colum)
{
    try
    {
        Console.WriteLine($"cell [{row}], [{colum}] contains the value: {multi[row,colum]}");
    }
    catch
    {
        Console.Write("There is no such position in the array");
    }
}

void FindValueClassic(double [,] multi, int row, int colum)
{    
    double result = -1;
    if(row > multi.GetLength(0) || colum > multi.GetLength(1))
    {
        Console.Write("There is no such position in the array");
    }
    else
    {
       Console.WriteLine($"cell [{row}], [{colum}] contains the value: {multi[row,colum]}");
    }
    result = multi[row,colum];
}

//------------------------------------------------------------------------------------------------

double[,] matrix = CreateMultiDouble(GetStartNum(),GetEndNum());
PrintMultiDouble(matrix);
FindValue(matrix, GetRow(), GetColum());
FindValueClassic(matrix, GetRow(), GetColum());
