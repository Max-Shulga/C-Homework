// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

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

//---------------------------------------------------------------------------------

int length = CorrectLengthInput("Input array length: ");
int[] array = CreateInputRandomArray(length);

int FindMax = array[0];
int FindMin = array[0];

for (int i = 0; i < length; i++)
{
    if(FindMax < array[i])
    {
        FindMax = array[i];
    }
    if(FindMin > array[i])
    {
        FindMin = array[i];
    }
}
Console.WriteLine($"[{String.Join(", ", array)}]--> Max number in array is: {FindMax}. Min number in array is: {FindMin}");
Console.WriteLine($"Difference between maximum and minimum value is: {FindMax-FindMin}");