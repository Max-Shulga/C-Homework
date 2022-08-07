Console.Clear();
Console.Write("Input integer number: ");
int numA = Convert.ToInt32(Console.ReadLine());

if(numA %2 == 0)
    Console.Write(numA + " is even number");
else
Console.Write(numA + " is odd number");
