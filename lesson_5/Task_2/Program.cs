// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

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
//-------------------------------------------------------------------------------------
int length = CorrectLengthInput("Input array length: ");
int[] array = CreateInputRandomArray(length);
int sum = 0;
for (int i = 0; i < length; i += 2) //не совсем понятно что считать нечетными позициями, по идее нулевой  индекс массива является первым,
{                                   // т.е, занимает нечетную позицию в массиве. Если я не прав то i = 1 задать в цикле for 
    sum += array[i];
}
Console.Write($"[{String.Join(", ", array)}] sum of elements in odd positions is {sum}");
