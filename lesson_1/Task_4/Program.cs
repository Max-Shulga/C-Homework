Console.Clear(); 
Console.Write("Input random integer number: ");
int numA = Convert.ToInt32(Console.ReadLine());
int EvenNum = 2;

while (numA <= 0)
{
    Console.Write("Error. Input suitable number: ");
    int numB = Convert.ToInt32(Console.ReadLine());
    numA = numB;
}

if(numA == 1)
Console.Write("There are no even numbers in this segment");

while(EvenNum <= numA)
     {
        Console.Write(EvenNum + " ");
        EvenNum = EvenNum + 2;
     }
    