// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа. Например:
// 456 -> 5
// 782 -> 8 
// 918 -> 1

Console.Clear();

Console.Write("Input three-digit number: ");
int num1 = Convert.ToInt32(Console.ReadLine());

while(Math.Abs(num1) < 100 || Math.Abs(num1) >= 1000)
{ 
    Console.Write("This is not a three-digit number. Three-digit is when a digit, digit and one more digit, like this: 123 or -526. Try again: ");
    int temp = Convert.ToInt32(Console.ReadLine());
    num1 = temp;
}

int num2 = num1/10;
Console.Write($"The second digit of the number {num1} is :{Math.Abs(num1 = num2%10)}");

// // Or like this:

// String str = Console.ReadLine();
// char[] ch = str.ToCharArray();
// Console.Write(ch[2]); 

 