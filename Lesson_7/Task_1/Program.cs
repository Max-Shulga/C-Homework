// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

Console.Clear();
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

double [,] CreateMultiDouble(int row, int colum, int minNum, int MaxNum)
{
    double [,] multi = new double[row, colum];
    for (int i = 0; i < multi.GetLength(0); i++)
    {
        for (int j = 0; j < multi.GetLength(1); j++)
        {
            Random num = new Random();
            Random num2 = new Random();
            double digit = Convert.ToDouble(num.Next(minNum, MaxNum+1))*5;
            double NumDel = num2.Next(1,5); // тут вариантов для вычисленя очень много, но все какие то костыли(
            digit = digit / num2.Next(1,9);
            while(Math.Abs(digit) > MaxNum)
            {
                digit /= 1.9;
            }
            multi[i,j] = digit;
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

double [,] multi = CreateMultiDouble(GetRow(), GetColum(), GetStartNum(), GetEndNum());
PrintMultiDouble(multi);