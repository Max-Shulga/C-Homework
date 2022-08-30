// Задача 4. Со звездочкой(*). Найдите максимальное значение в матрице по каждой строке, ссумируйте их.
//  Затем найдети минимальное значение по каждой колонке, тоже ссумируйте их. 
//  Затем из первой суммы (с максимумами) вычтите вторую сумму(с минимумами)

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

int MaxInRows(int [,] multi)
{
    int sum = 0;
  
    for (int i = 0; i < multi.GetLength(0); i++)
    {
        int max = multi[i,0];
        for (int j = 0; j < multi.GetLength(1); j++)
        {
            if (max < multi[i,j])
            {
                max = multi[i,j];
            }
        }
        Console.WriteLine($"After {i+1} row sum of the max values is: {sum += max}");
    }
     return sum;
} 

int MinInRows(int [,] multi)
{
    int sum = 0;
  
    for (int i = 0; i < multi.GetLength(0); i++)
    {
        int min = multi[i,0];
        for (int j = 0; j < multi.GetLength(1); j++)
        {
            if (min > multi[i,j])
            {
                min = multi[i,j];
            }
        }
        Console.WriteLine($"After {i+1} row sum of the min values is: {sum += min}");
    }
     return sum;
} 

int MaxMinDif(int max, int min)
{
    int result = max - min;
    return result;
}

int [,] matrix = CreateMulti(GetDigitCondition("Input number of rows for Multidimensional Arrays: "),
GetDigitCondition("Input number of colums for Multidimensional Arrays: "),GetDigit("Input numerical start of range: "), 
GetDigit("Input numerical end of range: "));

PrintMulti(matrix);
int result = MaxMinDif(MaxInRows(matrix),MinInRows(matrix));
Console.WriteLine($"diference betwen max values and min values is: {result}");