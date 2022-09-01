// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)
bool CheckUnique (int[] array,int number) //проверяем нет ли такого числа в нашем масиве путем сравнения нового числа из уже имеющихся в массиве
{
    bool check = true;
    for (int i = 0; i < array.Length; i++)
    {
        if (number == array[i])
        {
            check = false;
        }
    }
    return check;
}

int[,,] CreateMulti(int row, int colum, int something) //Создания трехмерного массива
{
    int[,,] multi = new int[row, colum, something];
    int[] array = new int[row*colum*something]; //сюда будем добавлять сгенерированные числа
    int n = 0;
    for (int i = 0; i < multi.GetLength(0); i++)
    {
        for (int j = 0; j < multi.GetLength(1); j++)
        {
            for (int k = 0; k < multi.GetLength(2); k++)
            {
                multi[i,j,k] = new Random().Next(10, 100);
                while(CheckUnique(array, multi[i,j,k]) == false) //проверка на уникальность числа
                {
                    Console.WriteLine($"old number{multi[i,j,k]}");  
                    multi[i,j,k] = new Random().Next(10, 100);
                    CheckUnique(array, multi[i,j,k]);
                    Console.WriteLine($"new number{multi[i,j,k]}");
                } 
                array[n] =  multi[i,j,k];
                n++;
            }
        }
    }
    return multi;
}

void PrintMulti (int [,,] matrix) //вывод 2 мерного массива в консоль
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                Console.Write($"{matrix[i, j, k]}({i},{j},{k}) ");
            }
        }
        Console.WriteLine();
    }
}
// вроде бы работает:), но не понятно почему когда я ставил счетчик от 10 до 20 он мне в генирации(old number/new number) показывал числа больше 20, 
// но итоговый массив был верным. 

//---------------------------------------------------------------------------------------------------
Console.Clear();
int[,,] multiplex = CreateMulti(2,2,2);
PrintMulti(multiplex);
