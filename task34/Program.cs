// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2

Console.Clear();
Console.WriteLine("Программа, которая покажет количество чётных чисел в массиве.");
int[] array = new int[6];
void RandomArray(int[] arr)
{
    int size = arr.Length;
    for (int i = 0; i < size; i++)
    {
        arr[i] = new Random().Next(100, 999);
        Console.Write($"{arr[i]} ");
    }
}

void PrintArray(int[] arr2)
{
    int count = 0;
    int size = arr2.Length;
    for (int i = 0; i < size; i++)
    {
        int numb = arr2[i] % 2;
        if(numb == 0) 
        count++;
    }
    Console.Write($"Количество чётных чисел в массиве = {count}");
}

RandomArray(array);
Console.WriteLine();
PrintArray(array);
Console.WriteLine();