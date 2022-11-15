// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0

Console.Clear();
Console.WriteLine("Программа, которая находит сумму элементов, стоящих на нечётных позициях одномерного массива.");
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
    int sum = 0;
    int size = arr2.Length;
    for (int i = 0; i < size; i++)
    {
        if (i % 2 != 0) sum = sum + array[i];
    }
    Console.WriteLine($"Сумма чисел на нечётных позициях = {sum}");
}

RandomArray(array);
Console.WriteLine();
PrintArray(array);
Console.WriteLine();