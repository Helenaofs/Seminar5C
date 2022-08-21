// Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

using System;

Console.WriteLine("Введите размер массива:");
int size = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[size];

void FillArray(int[] numbers)
{
    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = new Random().Next(0, 10);
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

void MultiplyNumbers(int[] numbers)
{
    int end = numbers.Length - 1;
    for (int i = 0; i < numbers.Length / 2; i++)
    {
        Console.Write(numbers[i] * numbers[end] + " ");
        end--;
    }
    if (numbers.Length % 2 == 1)
    {
        Console.Write(numbers[numbers.Length / 2]);
        Console.WriteLine();
    }
}


FillArray(numbers);
PrintArray(numbers);
MultiplyNumbers(numbers);
