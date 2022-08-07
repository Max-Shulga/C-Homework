Console.Clear();

Console.Write("Input randon  number: ");

int num = Convert.ToInt32(Console.ReadLine()!);

int num2 = -num;

if(num < 0)
{
    int temp = num;
    num = num2;
    num2 = temp;
    
}

while(num >= num2)
{
    Console.Write(-num + " ");
    num = num - 1; 
}
