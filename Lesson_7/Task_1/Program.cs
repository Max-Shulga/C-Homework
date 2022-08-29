// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

Console.Clear();
int GetDigitCondition(string message)
{
    Console.WriteLine(message);
    int colum = int.Parse(Console.ReadLine()!);
    while(colum < 1)
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

double [,] CreateMultiDouble(int row, int colum, int minNum, int MaxNum)
{
    double [,] multi = new double[row, colum];
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
            else                                    //не придумал как проверить число на второй знак после запято что бы по итогу красивее сделать 
            {                                                     
               Console.Write($"{multi[i, j]:f2}\t ");
            }
        }
        Console.WriteLine();
    }
}

//----------------------------------------------------------------------------------------

double [,] multi = CreateMultiDouble(GetDigitCondition("Input number of rows for Multidimensional Arrays: "),
GetDigitCondition("Input number of colums for Multidimensional Arrays: "),GetDigit("Input numerical start of range: "), 
GetDigit("Input numerical end of range: "));
PrintMultiDouble(multi);