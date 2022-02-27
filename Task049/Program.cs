//Задача 49. Показать двумерный массив размером m×n заполненный вещественными числами

using System;


int x, y;

Input(out x, out y);
double[,] matrix = new double[x, y];
PrintArray(matrix);
FillArray(matrix);
System.Console.WriteLine();
PrintArray(matrix);

void Input(out int m, out int n)
{
    System.Console.Write("Введите количество строк массива ");
    m = Convert.ToInt32(Console.ReadLine());

    System.Console.Write("Введите количество столбцов массива ");
    n = Convert.ToInt32(Console.ReadLine());
}

void PrintArray(double[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            System.Console.Write($"{arr[i, j],6} |");
        }
        System.Console.WriteLine();
    }
}

void FillArray(double[,] arr)
{
    double c = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            c = Convert.ToDouble(new Random().Next(1, 100));
            arr[i, j] = Math.Round(c / 4, 2);
        }
    }
}