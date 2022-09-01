// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2 = 14
// 5 9 2 3 = 19
// 8 4 2 4 = 18
// 5 2 6 7 = 20
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

//не совсем понимаю, а какая разница какой формы будет двумерный массив. Поэтому будет как всегда, выбирать можете любой формы и содержания:)


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
        number = int.Parse(Console.ReadLine()!);
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

int SumInRow(int [,] matrix, int row)  //принимает матрицу и номер строки.
{
    int sum = 0;
    for (int i = 0; i < matrix.GetLength(1); i++) //идем по столбцам, вдоль строки
    {
        sum += matrix[row,i]; //cчитаем сумму эллементов в строке
    }
    return sum;
}

int FindSmallestSumRow(int [,] matrix)
{
    int RowSum = SumInRow(matrix, 0);
    int MinRowIndex = 0;
    for (int i = 0; i < matrix.GetLength(0); i++) //идем по строкам
    {
        int CurrentRowSum = SumInRow(matrix, i);
        if (RowSum > CurrentRowSum)
        {
            RowSum = CurrentRowSum;
            MinRowIndex = i+1;
        }
        Console.WriteLine($"In {i+1} row, sum of elements is: {CurrentRowSum}");
    }
    return MinRowIndex;
}

//-------------------------------------------------------------------------------------------------------------------
Console.Clear();
int row = GetDigitCondition(GetDigit("Input number of rows for Multidimensional Arrays: "), ">", 1);
int colum = GetDigitCondition(GetDigit("Input number of colums for Multidimensional Arrays: "), ">", 1);
int start = GetDigit("Input numerical start of range: ");
int end = GetDigit("Input numerical end of range: ");
int[,] matrix = CreateMulti(row,colum,start,end);
Console.WriteLine();
PrintMulti(matrix);
int small = FindSmallestSumRow(matrix);
Console.Write($"Smallest sum of elements in row {small}");
