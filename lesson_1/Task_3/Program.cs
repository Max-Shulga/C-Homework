Console.Clear();
Console.Write("Input integer number: ");
int numA = Convert.ToInt32(Console.ReadLine());

while (numA == 0)
{
    Console.Write("Error. Input suitable number: ");
    int numB = Convert.ToInt32(Console.ReadLine());
    numA = numB;
}

if(numA %2 == 0)
{
    Console.Write(numA + " is even number");
}
else
{
Console.Write(numA + " is odd number");
}