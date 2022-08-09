Console.Clear();

Console.Write("Input first number: ");
int numA = Convert.ToInt32(Console.ReadLine());
Console.Write("Input second number: "); 
int numB = Convert.ToInt32(Console.ReadLine());

if(numA == numB)
{
   Console.Write("The first number equal the second number");
}
if(numA > numB)
{
    Console.Write("The first number bigger than the second number");
}
else
{
    Console.Write("The second number bigger then the first number");
}
