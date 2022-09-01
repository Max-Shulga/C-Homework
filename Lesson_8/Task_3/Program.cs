// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18



int GetDigit(string message) // Запрос числа без условия
{
    Console.WriteLine(message);
    int number = int.Parse(Console.ReadLine()!);
    return number;
}

int GetDigitCondition (int number, string sign, int numb) //Запрос числа с условием
{
    int Check(int number)
    {
        Console.Write("Invalid digit, please enter the correct digit: ");
        number =  int.Parse(Console.ReadLine()!);
        return number;
    }
    switch(sign)
    {
        case "==": while(number != numb) number = Check(number); break;
        case "!=": while(number == numb) number = Check(number); break;
        case ">=": while(number <= numb) number = Check(number); break;
        case "<=": while(number >= numb) number = Check(number); break;
        case ">": while(number < numb) number = Check(number); break;
        case "<": while(number > numb) number = Check(number); break;
        default : Console.Write("Invalid equals sign"); break;
    }
    return number;
}

int[,] CreateMulti(int row, int colum, int minNum, int MaxNum) //Создания двумерного массива
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

void PrintMulti (int [,] matrix) //вывод 2 мерного массива в консоль
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]}\t");
        }
        Console.WriteLine();
    }
}

int [,] MatrixMultiplication(int [,] matrix1,int [,] matrix2)
{
    int [,] matrix = new int[matrix1.GetLength(0),matrix1.GetLength(1)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = matrix1[i,j] * matrix2[i,j]; //как то очень просто на фоне двух предыдущих задач.Если я вдруг что то не верно то в этой
        }                                              //строке можно поставить любую математическую операцию через знаки или Math. ...
    }
    return matrix;
}
//------------------------------------------------------------------------------------------------------------------------------

Console.Clear();

int row = GetDigitCondition(GetDigit("Input number of rows for Multidimensional Arrays: "), ">", 1);
int colum = GetDigitCondition(GetDigit("Input number of colums for Multidimensional Arrays: "), ">", 1);
int start = GetDigit("Input numerical start of range for: ");
int end = GetDigit("Input numerical end of range: ");
Console.WriteLine();
int[,] matrix1 = CreateMulti(row,colum,start,end);
int[,] matrix2 = CreateMulti(row,colum,start,end);
PrintMulti(matrix1);
Console.WriteLine();
PrintMulti(matrix2);
int[,] matrixMultiplied = MatrixMultiplication(matrix1,matrix2);
Console.WriteLine();
PrintMulti(matrixMultiplied);