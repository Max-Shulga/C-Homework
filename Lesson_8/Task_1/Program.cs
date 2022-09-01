// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

//очень много описаний потому что не очень получалось все сделать так как задумывал поэтому прописывал что бы не запутаться
//удалять уже не стал вдруг что то неверно потом будет легче исправлять

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

int MaxIndexInRows(int [,] matrix,int columStart, int row) // принимает двумерный массив, то с какого столбца начинать работать и в которой строке.
{
    int columIndex = columStart; //присваиваем стартовый индекс
    for (int colum = columStart; colum < matrix.GetLength(1); colum++) //работаем в столбцах
    {
        if (matrix[row, columIndex] < matrix[row,colum]) // сравниваем значения в текущем столбе со следующим
        {
            columIndex = colum;  //если следующий больше запоминаем индекс столбца 
        }
    }
    return columIndex;    //после цикла возвращяет значение максимального индекса столбца.
} 

int[,] SortMulti(int[,] matrix)           //тут вопрос не лучше ли в таких случаях поместить функцию MaxIndexInRows внутрь SortMulti,  
{                                         //ведь она только для лучшей читаемсости ее содержимое можно было просто перенести.
    for (int i = 0; i < matrix.GetLength(0); i++) //строки
    {
        for (int j = 0; j < matrix.GetLength(1); j++)//столбцы
        {
            int idexMaxColum = MaxIndexInRows(matrix,j,i); // из функции получаем индекс столбца с максимальным значением
            int temp = matrix[i,j];//записываем  позицию строки
            matrix [i,j] = matrix[i, idexMaxColum]; //в эту позицию кладем максимальное значение строки
            matrix[i, idexMaxColum] = temp; //на место максимального кладем первое
        }
    }

    return matrix;
} 

//--------------------------------------------------------------------------------------------------------------------------------------------

Console.Clear();
int row = GetDigitCondition(GetDigit("Input number of rows for Multidimensional Arrays: "), ">", 1);
int colum = GetDigitCondition(GetDigit("Input number of colums for Multidimensional Arrays: "), ">", 1);
int start = GetDigit("Input numerical start of range: ");
int end = GetDigit("Input numerical end of range: ");
int[,] matrix = CreateMulti(row,colum,start,end);
PrintMulti(matrix);
SortMulti(matrix);
Console.WriteLine();
PrintMulti(matrix);
