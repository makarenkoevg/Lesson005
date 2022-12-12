// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.


using System;
using static System.Console;

Clear();

Write("Введите количество элементов массива: ");
int rows = int.Parse(ReadLine());

double[] array = GetArray(rows, 0, 10);
PrintArray(array);
WriteLine();

WriteLine($"Разница между максимальным и минимальным значением: {MinMaxDif(array):f2}");



double MinMaxDif(double[] array)
{
    double min = 0;
    double max = 0;
    if (array[0]<array[1])
    {
        min=array[0];
        max=array[1];
    } 
    else
    {
        min=array[1];
        max=array[0];
    }

    for (int i = 2; i < array.Length; i++)
    {
        if (array[i]<min) min=array[i];
        if (array[i]>max) max=array[i];
    }
    return max-min;

}
void PrintArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
      
            Write($"{array[i]:f2} ");

    }

}
double [] GetArray(int m, int min, int max)
{
    double [] result = new double[m];
    for (int i = 0; i < m; i++)
    {
       
        result[i] = new Random().NextDouble()*(max-min)+min;

    }
    return result;
}