﻿Console.Clear();

Console.Write("Input random three-digit number: ");
int num = Convert.ToInt32(Console.ReadLine());

while(num > 100)
{
    num = num - 100;
}

while(num > 10)
{
    num = num - 10;
}
Console.Write(num);
