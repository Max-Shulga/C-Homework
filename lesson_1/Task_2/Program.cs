//Можно было бы обойтись двум блоками if, если бы Вы изначально присвоили переменной maxNum значение любого из чисел.
Console.Clear();

Console.Write("Input first number: ");
int numA = Convert.ToInt32(Console.ReadLine());
Console.Write("Input second number: "); 
int numB = Convert.ToInt32(Console.ReadLine());
Console.Write("Input third number: "); 
int numC = Convert.ToInt32(Console.ReadLine());

int MaxNum = numA;
if(MaxNum < numB)
{
MaxNum = numA;
}
if(MaxNum < numC)
{
    MaxNum = numC;
}
Console.Write($"{MaxNum} is the biggest of the proposed numbers");