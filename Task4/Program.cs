// Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99].
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

using System;

Console.WriteLine("Введите размер массива:");
int size = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[size];

void FillArray(int[] numbers)
{   
    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = new Random().Next(0, 300);
    }
}

void PrintArray(int[] numbers)
{
    Console.Write("[");
    for (int i = 0; i < numbers.Length - 1; i++)
    {
        Console.Write(numbers[i] + ", ");
    }
    Console.Write(numbers[numbers.Length - 1] + "]");
    Console.WriteLine();
}

int SortArray(int[] numbers)
{
    int res = 0;
    int min = 10;
    int max = 99;
    for (int i = 0; i < numbers.Length; i++)
    {
        if ((numbers[i] >= min) && (numbers[i] <= max))
        {
            res += 1;
        }
    }
    return res;
}

FillArray(numbers);
PrintArray(numbers);
Console.WriteLine("Колличество элементов массива, лежащих в отрезке от 10 до 99: " + SortArray(numbers));
