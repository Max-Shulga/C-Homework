// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

//Незакоментированный код будет генерировать  массив из заданого количество элементов, так интереснее вроде бы,
//  а то задание один в один как на семенари, второе же решение по условию на всякий случай.

//самое последнее решение на случай, если вдруг неверно понял условие

// Console.Clear();
// Random num = new Random();

// Console.Write("Input the length of the array: ");
// int length = int.Parse(Console.ReadLine()!);
// Console.Write("Enter the beginning of the range: ");
// int start = int.Parse(Console.ReadLine()!);
// Console.Write("Enter the end of the range: ");
// int end = int.Parse(Console.ReadLine()!);
// int[] array = new int[length];

// for(int i = 0; i < length; i++)
// {
//     array[i] = num.Next(start,end+1);
//     Console.Write(array[i]+ " ");
// }

// // Console.Clear();
// Random num = new Random();
// int[] array = new int[8];
// for(int i = 0; i < 8; i++)
// {
//     array[i] = num.Next(-20,21);
//     Console.Write(array[i] + " ");
// }



// Console.Clear();
// Console.Write("Input the numbers by the coma: ");
// string[] array = {Convert.ToString(Console.ReadLine()!)};
// for(int i = 0; i < array.Length; i++)
// {
//     Console.Write(array[i]+ " ");
// }




int[] CreateRandomArray(int N, int start, int end)
{
    int[] RandomArray = new int[N];
    for (int i = 0; i < N; i++)
    {
        RandomArray[i] = new Random().Next(start, end + 1);
    }
    return RandomArray;
}
int[] CreateArray()
{
    Console.WriteLine("Введите количество элементов массива");
    int size = Convert.ToInt32(Console.ReadLine());
    int[] RandomArray = new int[size];
    for (int i = 0; i < size; i++)
    {   
        Console.WriteLine($"Введите {i+1} элемент массива");
        RandomArray[i] = Convert.ToInt32(Console.ReadLine());
    }
    return RandomArray;
}
void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}
Console.Clear();
Console.WriteLine("Введите количество элементов в массиве");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите первое число случайно генерируемого диапазона");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите последнее число случайно генерируемого диапазона");
int max = Convert.ToInt32(Console.ReadLine());

int[] myRandomArray = CreateRandomArray(num, min, max);
ShowArray(myRandomArray);
Console.WriteLine("-------");
int[] myArray = CreateArray();
ShowArray(myArray);

Console.Clear();
int[] array = GetRandomArray(8,0,100);
Console.WriteLine($"[{String.Join(", ", array)}]");


int[] GetRandomArray(int size,int minValue,int maxValue)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(minValue,maxValue);
    }

    return result;
}
