// Генерируются два случайных целых числа a и b в интервале [10 – 30].
// Если a > b, выводится их разность, eсли a < b, выводится сумма,
// eсли a == b, выводится сообщение “числа равны”. (оператор if)

Random num = new Random();
int numA = num.Next(10,30);
int numB = num.Next(10,30);
int result = 0;

Console.WriteLine(numA +" "+numB);

if (numA != numB)
{
    
    if (numA < numB)
    {
        result = numA + numB;
        Console.Write($"the sum of the numbers is: {result}");
    }
    else
    {
    result = numA - numB;
    Console.Write($"the difference between the numbers is: {result}");
    }
}

else
{ 
    Console.Write("the numbers are equal");
}

