// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

using System;

Console.WriteLine("Введите размер массива:");
int size = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[size];

void FillArray(int[] numbers)
{
    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = new Random().Next(100, 999);
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

int EvenNumbers(int[] numbers)
{
    int evenNum = 0;
    for (int i = 0; i < numbers.Length; i++)
    {
        if (numbers[i] % 2 == 0)
        {
            evenNum++;
        }
    }
    return evenNum;
}

FillArray(numbers);
WriteArray(numbers);
Console.WriteLine("Четных чисел в массиве - " + EvenNumbers(numbers));

