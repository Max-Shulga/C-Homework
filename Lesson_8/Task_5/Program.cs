// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

//Задание вроде сделано, но оооооочень плохо, я на досуге посежу постараюсь как 
// нибудь через рекурсию красиво, но пока ничего не получается прикреплю в Task_5.5 то на чем в ней остановился.
int[,] CreateMulti() //Создания двумерного массива
{
    int[,] multi = new int[4, 4];
    int number = 1;
    for (int i = 0; i < multi.GetLength(0); i++)
    {
        multi[0, i] = number;
        number++;
    }
    for (int i = 1; i < multi.GetLength(1); i++)
    {
        multi[i, 3] = number;
        number++;
    }
    for (int i = 2; i >= 0; i--)
    {
        multi[3, i] = number;
        number++;
    }
    for (int i = 2; i > 0; i--)
    {
        multi[i, 0] = number;
        number++;
    }

    
    for (int i = 1; i < 3; i++)
    {
        multi[1, i] = number;
        number++;
    }
    for (int i = 2; i > 0; i--)
    {
        multi[2, i] = number;
        number++;
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

int[,] matrix = CreateMulti();
PrintMulti(matrix);
