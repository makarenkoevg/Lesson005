//Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях (не индексах, а позициях!!!)

using System;
using static System.Console;

Clear();

Write("Введите количество элементов массива: ");
int rows = int.Parse(ReadLine());

int[] array = GetArray(rows, 0, 10);
PrintArray(array);

WriteLine($"=> {Summ(array)}");

int[] GetArray(int m, int min, int max)
{
    int[] result = new int[m];
    for (int i = 0; i < m; i++)
    {
        result[i] = new Random().Next(min, max + 1);
    }
    return result;
}

int Summ(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i+=2)
    {
        sum+=array[i];
    }
    return sum;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
      
            Write($"{array[i]} ");

    }

}
