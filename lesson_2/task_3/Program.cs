//Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.Например:
// 6 -> да 
// 7 -> да 
// 1 -> нет

Console.Clear();

Console.Write("Enter the number of the day of the week: ");
int num = Convert.ToInt32(Console.ReadLine());

while(num <= 0 || num >= 7)
    {
    Console.Write("Wront digit. Try again: ");
    int temp = Convert.ToInt32(Console.ReadLine());
    num = temp;
    }

if(num == 6 || num == 7)
{
    Console.Write("It's a holiday");
}
else
{
    Console.Write("It's a weekday");
}