// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

using System;

double[] numbers = new double[5];

void FillArray(double[] numbers)
{
    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = new Random().Next(1, 99);
    }
}

void WriteArray(double[] numbers)
{
    Console.Write("[");
    for (int i = 0; i < numbers.Length - 1; i++)
    {
        Console.Write(numbers[i] + ", ");
    }
    Console.Write(numbers[numbers.Length - 1] + "]");
    Console.WriteLine();
}

double DifferenceMaxMin(double[] numbers)
{
    double min = numbers[0];
    double max = numbers[0];
    double diff = 0;
    for (int i = 0; i < numbers.Length; i++)
    {
        if (min > numbers[i])
        {
            min = numbers[i];
        }
        if (max < numbers[i])
        {
            max = numbers[i];
        }
        diff = max - min;
    }
    return diff;
}

FillArray(numbers);
WriteArray(numbers);
Console.WriteLine("Разница максимального и минимального значения равна: " + DifferenceMaxMin(numbers));
