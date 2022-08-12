Random num = new Random();
int numC = num.Next(-10, 10);
int numD = num.Next(-10, 10);
int result = 0;
Console.WriteLine(numC + " " + numD);
if(numC ==0 || numD == 0)
{
    result = 0;
    Console.Write(result);
}
else
{
    if(numC%2 ==0)
    {
        if(numD%2 == 0)
        {
            if(Math.Abs(numC)>Math.Abs(numD))
            {
                result = numC / numD;  
            }
            else
            {
                result = numD / numC;
            }
        }  
        else
        {
            result = numC * numD;
        }
    }
    if(numC%2 != 0)
    {
        if(numD%2 != 0)
        {
            result = numC + numD;  
        }  
        else
        {
            result = numC * numD;
        }
}
Console.Write(result);
}
