// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

//Незакоментированный код будет генерировать  массив из заданого количество элементов, так интереснее вроде бы,
//  а то задание один в один как на семенари, второе же решение по условию на всякий случай.

Console.Clear();
Random num = new Random();

Console.Write("Input the length of the array: ");
int length = int.Parse(Console.ReadLine()!);
Console.Write("Enter the beginning of the range: ");
int start = int.Parse(Console.ReadLine()!);
Console.Write("Enter the end of the range: ");
int end = int.Parse(Console.ReadLine()!);
int[] array = new int[length];

for(int i = 0; i < length; i++)
{
    array[i] = num.Next(start,end);
    Console.Write(array[i]+ " ");
}

// Console.Clear();
// Random num = new Random();
// int[] array = new int[8];
// for(int i = 0; i < 8; i++)
// {
//     array[i] = num.Next(-20,20);
//     Console.Write(array[i] + " ");
// }