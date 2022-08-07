Console.Clear();

Console.Write("Input first number: ");
int numA = Convert.ToInt32(Console.ReadLine());
Console.Write("Input second number: "); 
int numB = Convert.ToInt32(Console.ReadLine());
Console.Write("Input third number: "); 
int numC = Convert.ToInt32(Console.ReadLine());
int MaxNum = 0;

if(numA > numB)
MaxNum = numA;

else
MaxNum = numB;

if(MaxNum < numC)
MaxNum = numC;

Console.Write(MaxNum + " is the biggest of the proposed numbers");