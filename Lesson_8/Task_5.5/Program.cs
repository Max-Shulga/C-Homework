// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

//Странное задание, какие то кастыли красиво не выходит, и как то гугл ничего изящнее не предлагает

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
        int temp = int.Parse(Console.ReadLine()!);
        number = temp;
        return temp;
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

int[,] CreateMulti(int row, int colum) //Создания двумерного массива
{

    int[,] multi = new int[row, colum];
    for (int i = 0; i < multi.GetLength(0); i++)
    {
        multi[i,0] = 1;
    }
        for (int i = 0; i < multi.GetLength(1); i++)
    {
        multi[0,i] = 1;
    }
     for (int i = 0; i < multi.GetLength(0); i++)
    {
        multi[row-1,i] = 1;
    }
        for (int i = 0; i < multi.GetLength(1); i++)
    {
        multi[i,colum-1] = 1;
    }
    return multi;
}

void PrintMulti(int[,] matrix) //вывод 2 мерного массива в консоль
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

//-------------------------------------------------------------------------------------
Console.Clear();
int row = GetDigitCondition(GetDigit("Input number of rows for Multidimensional Arrays: "), ">", 1);
int colum = GetDigitCondition(GetDigit("Input number of colums for Multidimensional Arrays: "), ">", 1);
int[,] matrix = CreateMulti(row,colum);


Console.WriteLine();

int count = 0;
int[] FillImage(int row, int col)
{
    int[] inf = new int[2];
    count++;
    if (matrix[row,col] == 0)
    {
        matrix[row, col] = count;
        inf[0] = count;
        FillImage(row, col + 1);inf[0] = count -= 1;
        FillImage(row + 1, col);inf[0] = count -= 1;
        FillImage(row, col - 1);inf[0] = count -= 1;
        FillImage(row - 1, col);inf[0] = count -= 1;
    }
    return count;
}



FillImage(1,1);
PrintMulti(matrix);