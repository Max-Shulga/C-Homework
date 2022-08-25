// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

// Дополнительно (на оценку не влияют):

// Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10

// Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

// Задача 45: Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.

//!!!Экспериментальный формат сдачи, если очень не удобно напишите в коментариях к дз, и я буду делать как обычно.Спасибо!!!

//------------------------------------------------------------------------------------------
int CorrectLengthInput(string text = "")
{
    Console.Write(text);
    int input = int.Parse(Console.ReadLine()!);
    while(input <1)
    {
        Console.Write("Incorrect number. Try again: ");
        int TryAgain = int.Parse(Console.ReadLine()!);
        input = TryAgain;
    }
    return input;
}
int[] CreateInputRandomArray(int length)
{
    Console.Write("Input numerical start of range: ");
    int start = int.Parse(Console.ReadLine()!);
    Console.Write("Input numerical end of range: ");
    int end = int.Parse(Console.ReadLine()!);
    int[] array = new int[length];
    for (int i = 0; i < length; i++)
    {
        array[i] = new Random().Next(start,end+1); 
    }
    return array;
} 
//--------------------------------------------------------------------------------------------
Console.Write("Input task number: ");
int TaskNum = int.Parse(Console.ReadLine()!);

if(TaskNum == 41)
{ 
    Console.Clear();
    int length = 0; 
    while(length == 0)
    {
        try
        {
            Console.Write("Input numbers separated by spaces: ");
            int[] numbers = Console.ReadLine()!.Split().Select(int.Parse).ToArray();
            Console.Write($"[{String.Join(", ", numbers)}]");
            length = numbers.Length;
            int count = 0;
            for (int i = 0; i < length; i++)
            {
                if(numbers[i] > 0)
                { 
                    count++;
                }
            }
            Console.Write($"You entered {count} numbers greater than zero");
        }
        catch
        {
            Console.WriteLine("Incorent input, Try again: ");    //исключаем ошибки по типу двойного пробела, запятой и всего что не является числами
        }
    }
}

// Не знаю, может это и костыли, может тут можно было и на много проще но мне очень понравилось пытаться сделать именно так ;)

//------------------------------------------------------------------------------------------
if(TaskNum == 43)
{
    Console.Clear();
    Console.WriteLine("Input b1 : ");
    double b1 = double.Parse(Console.ReadLine()!);
    Console.WriteLine("Input k1 : ");
    double k1 = double.Parse(Console.ReadLine()!);
    Console.WriteLine("Input b2 : ");
    double b2 = double.Parse(Console.ReadLine()!);
    Console.WriteLine("Input k2 : ");
    double k2 = double.Parse(Console.ReadLine()!);

    double  x = - ((b1 - b2) / (k1 - k2)); 
    double y = k2 * x + b2;
    Console.Write($"{(x, y)})");
}
//------------------------------------------------------------------------------------------
if(TaskNum == 42)
    {
    Console.Clear();
    Console.Write("Введите число: "); 
    int num = int.Parse(Console.ReadLine()!);
    string Binary = "";
    while(num != 0)
    {
        if (num%2 == 0) 
        {
            Binary += "0"; 
        }
        else
        {
            Binary += "1"; 
        }
        num = num/2;
    }

    for (int i = 0; i < Binary.Length; i++)
        {
         Console.Write(Binary[Binary.Length-1 - i]);
        }
}
//------------------------------------------------------------------------------------------
if(TaskNum == 44)
{
    Console.Clear();
    int length = CorrectLengthInput("Input array length: ");
    int[] FibonacciArray = new int[length];
    FibonacciArray[0] = 0;
    FibonacciArray[1] = 1;
    for (int i = 2; i < length; i++)
    {
        FibonacciArray[i] = FibonacciArray[i-2] + FibonacciArray[i-1];
    }
    Console.Write($"[{String.Join(", ", FibonacciArray )}]");



}
else
{
    Console.Write($"No task with this number: {TaskNum}");
}
//------------------------------------------------------------------------------------------
if(TaskNum == 45)
{
    Console.Clear();
    int length = CorrectLengthInput("Input array length: ");
    int[] OriginalArray = CreateInputRandomArray(length);
    int[] CopyArray = new int[length];
    for (int i = 0; i < length; i++)
    {
        CopyArray[i] = OriginalArray[i];
    }
    Console.Write($"Your array: [{String.Join(", ", OriginalArray  )}]\n Copy array: [{String.Join(", ", CopyArray)}]");
}

//!!!Экспериментальный формат сдачи, если очень не удобно напишите в коментариях к дз, и я буду делать как обычно.Спасибо!!!