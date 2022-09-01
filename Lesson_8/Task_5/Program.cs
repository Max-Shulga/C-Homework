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

int[,] CreateSpiral(int size)

{
    int elements = size * size;
    int countElement = 0;
    int begin = 0;
    int [,] matrix = new int[size,size];
    while (countElement < elements)
    {
        for (int i = begin; i < size; i++)
        {
            countElement++;
            matrix[begin, i] = countElement;
        }
        for (int i = begin +1; i < size; i++)
        {
            countElement++;
            matrix[i, size-1] = countElement;
        }
        for (int i = size-2; i >= begin; i--)
        {
            countElement++;
            matrix[size -1,i] = countElement;
        }
        for (int i = size -2; i >= begin+1; i--)
        {
            countElement++;
            matrix[i,begin] = countElement;
        }
        size -= 1;
        begin += 1;

    }
    return matrix;
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

//------------------------------------------------------------------------------
int size = GetDigitCondition(GetDigit("Input matrix size: "),">", 1);
int[,] matrix = CreateSpiral(size);
PrintMulti(matrix);
