// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

// ----------------------------------------------------------------------------------------------------------------------------

Console.Clear();

Console.Write("Input random number: ");
int number = int.Parse(Console.ReadLine()!);
string ReversNum = "";

if(number < 0)
{
    ReversNum = ReversNum + "-";
}
string NumberStr = number.ToString(); //<---вот эту строку

number = Math.Abs(number);

//было неприятно ограничивать диапазон но по дз условия для 5-тизначных, если это важно, то пожалуйста учтите его)
//если будете с ним проверять то строку string NumberStr = number.ToString(); нужно поместить за цикл,
// в противном случае будет плохо работать с отрицательными числами
// while(Math.Abs(number)<10000 || Math.Abs(number)>99999)
// {
//     Console.Write("input five-digit Number: ");
//     int number2 = int.Parse(Console.ReadLine()!);
//     number = number2;
// }

                                      //<---вот сюда

if(number >= 10)
{
    while(number > 0)
    {
        ReversNum = ReversNum + number%10;
        number = number/10;
    }
    if(ReversNum == NumberStr)
    {
        Console.Write($"Your digit: {NumberStr} is a palindrome");
    }
    else
    {
        Console.Write($"your digit: {NumberStr} is not a palindrome");
    }

}
else
{
    Console.Write($"your digit: {NumberStr} is not a palindrome");
}


// ----------------------------------------------------------------------------------------------------------------------------





// ---Плохо работающий черновик  еще одного варианты решения,
//  пока не придумал как при дилении на 10,100 и тд, при остатке >5 что бы оно на 1 не увеличевало полученое после деления число

// Console.Clear();

// Console.Write("Input random number: ");
// int number = int.Parse(Console.ReadLine()!);
// int count = 0;
// int number2 = number;

// while(number > 0)
// {
//     number = number/10;
//     count++;
// }
// int NumberLenghth = 0;
// int NumS = number2%10;
// int numB = Convert.ToInt32(number2/Math.Pow(10, count-1));
// while(count > NumberLenghth)
// {
//     if (NumS == numB)
//     {
//         number2 = number2/10;
//         count--;
//         NumberLenghth++;
//     }
//     if (NumS != numB)
//     {
//         Console.Write("Not polindrome");
//         break;
//     }
// }
// if (count<=NumberLenghth)
// {
//         Console.Write("number is polindrome");
// }

