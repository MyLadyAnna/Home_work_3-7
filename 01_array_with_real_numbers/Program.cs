﻿// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

double[,] GetArrayRandom(int rows, int cols, int minValue = 0, int maxValue = 10)
{
    double[,] array = new double[rows, cols];
    var rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.NextDouble() * (maxValue - minValue) + minValue;
        }
    }
    return array;
}

void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]:f} ");
        }
        Console.WriteLine();
    }
}


double[,] array = GetArrayRandom(3, 4);
PrintArray(array);