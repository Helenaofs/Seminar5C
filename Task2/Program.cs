// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

using System;

int[] numbers = new int[4];

void FillArray(int[] numbers)
{
    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = new Random().Next(-99, 99);
    }
}

void WriteArray(int[] numbers)
{
    Console.Write("[");
    for (int i = 0; i < numbers.Length - 1; i++)
    {
        Console.Write(numbers[i] + ", ");
    }
    Console.Write(numbers[numbers.Length - 1] + "]");
    Console.WriteLine();
}

int SumNumbers(int[] numbers)
{
    int sum = 0;
    for (int i = 1; i < numbers.Length; i += 2)
    {
        sum += numbers[i];
    }
    return sum;
}

FillArray(numbers);
WriteArray(numbers);
Console.WriteLine("Сумма чисел на нечетных позициях равна: " + SumNumbers(numbers));
