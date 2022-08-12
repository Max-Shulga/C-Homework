//Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет. Наприме:
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Clear();

Console.Write("Input random number: ");
int num = Convert.ToInt32(Console.ReadLine());

if(Math.Abs(num) < 100)
{ 
    Console.Write("There is no third digit");
}

else
{
    while(Math.Abs(num) >= 1000)
    {
        num = num/10;
    }
    Console.Write(Math.Abs(num%10));
}

