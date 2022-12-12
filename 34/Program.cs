//Задайте массив заполненный случайными положительными трёхзначными числами.
//  Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

using System;
using static System.Console;

Clear();

Write("Введите количество элементов массива: ");
int rows = int.Parse(ReadLine());

int[] array = GetArray(rows, 100, 999);
PrintArray(array);

WriteLine($"=> {Count(array)}");

int[] GetArray(int m, int min, int max)
{
    int[] result = new int[m];
    for (int i = 0; i < m; i++)
    {
        result[i] = new Random().Next(min, max + 1);
    }
    return result;
}

int Count(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if ((array[i] % 2) == 0)
        {
            count+=1;
        }
    }
    return count;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
      
            Write($"{array[i]} ");

    }
}