// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

int GetDigitCondition(string message)
{
    Console.WriteLine(message);
    int colum = int.Parse(Console.ReadLine()!);
    while(colum < 0)
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

double [,] CreateMultiDouble(int minNum, int MaxNum)
{
    double [,] multi = new double[10, 10];
    for (int i = 0; i < multi.GetLength(0); i++)
    {
        for (int j = 0; j < multi.GetLength(1); j++)
        {
            Random digit = new Random();
            multi[i,j] = digit.NextDouble()*(MaxNum - minNum) + minNum;
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
        Console.WriteLine($"cell [{row}], [{colum}] contains the value: {multi[row,colum]:2f}");
    }
    catch
    {
        Console.Write("There is no such position in the array");
    }
}

//мне прям очень понравилось верхнее решение, но на всякий и нижнее оставлю тут

void FindValueClassic(double [,] multi, int row, int colum)
{    
    double result = -1;
    if(row > multi.GetLength(0) || colum > multi.GetLength(1))
    {
        Console.Write("There is no such position in the array");
    }
    else
    {
       Console.WriteLine($"cell [{row}], [{colum}] contains the value: {multi[row,colum]:2f}");
    }
    result = multi[row,colum];
}

//------------------------------------------------------------------------------------------------

Console.Clear();
double[,] matrix = CreateMultiDouble(GetDigit("Input numerical start of range: : "),GetDigit("Input numerical end of range: : "));
PrintMultiDouble(matrix);
FindValue(matrix, GetDigitCondition("Input the value of the row to search in the array: "), GetDigitCondition("Input the value of the colum to search in the array: "));
FindValueClassic(matrix, GetDigitCondition("Input the value of the row to search in the array: "), GetDigitCondition("Input the value of the colum to search in the array: "));
