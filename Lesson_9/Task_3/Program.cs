// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

// m = 2, n = 3 -> A(m,n) = 29

int AckermannFunction(int m, int n)
{
    if (m == 0)
        return n += 1;
    else if (m > 0 && n == 0)
        return AckermannFunction(m - 1, 1);
    else
        return AckermannFunction(m - 1, AckermannFunction(m, n - 1));
}

Console.Write(AckermannFunction(2, 3));
//Формула Аккермана из википедии но по ней m = 2, n = 3 -> A(m,n) = 29 вот это условие не выполняется. Как и таблице которая прикладывается к формуле.
//если m = 3, n = 2 то выполняется. Где то наткнулся на
//вот такую формулу где переменные по обратному вычисляются и там значение получаем из примера. Может это какая то модификация формулы.
//Либо как вариант в программировании у нас чуть другая логика вычисления.

// int AckermannFunction(int m, int n)
// {
//     if(n==0) return m += 1;
//     else if(n>0 && m == 0) return AckermannFunction(1,n - 1);
//     else return AckermannFunction(AckermannFunction(m-1,n),n-1);
// }

// Console.Write(AckermannFunction(2,3));
