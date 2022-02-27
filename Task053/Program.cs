// задача 53. В двумерном массиве показать позиции числа, заданного пользователем или указать, что такого элемента нет.

using System;

int x = 0, y = 0;
double a = 0;

Input(out x, out y);
double [,] matrix = new double[x,y];
FillArray(matrix, x,y);
PrintArray(matrix, x,y);

System.Console.WriteLine("Введите число, позиции которое необходимо найти ");
a = Convert.ToDouble(Console.ReadLine());

PrintResults(FindElement(matrix, a));


void Input (out int m, out int n)
{
    string s = string.Empty;

    System.Console.Write("Введите количество строк массива ");
    s = Console.ReadLine();
    m = Convert.ToInt32(s);

    System.Console.Write("Введите количество столбцов массива ");
    s = Console.ReadLine();
    n = Convert.ToInt32(s);
}

void FillArray(double[,] arr, int a, int b)
{
    double c = 0;
    for (int i = 0; i < a; i++)
    {
        for (int j = 0; j < b; j++)
        {
            c = Convert.ToDouble(new Random().Next(1,40));
            arr[i,j]=Math.Round(c/3,2);
        }
    }
}

void PrintArray (double[,] arr, int a, int b)
{
    for (int i = 0; i < a; i++)
    {
        for (int j = 0; j < b; j++)
        {
            System.Console.Write($"{arr[i,j]} ");
        }
        System.Console.WriteLine();
    }
}

string FindElement(double[,] arr, double b)
{
    string res = string.Empty;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
           if (arr[i,j] == b)
           {
               res = res + $"{i}" + $"{j}";
           }
        }
    }
    return res;
}

void PrintResults(string res)
{
    if(res == string.Empty) System.Console.WriteLine("Такого элемента в массиве не обнаружено");
    else
    {
        System.Console.WriteLine("Позиции указанного числа в массиве");
        for (int i = 0; i < res.Length; i++)
        {
            System.Console.Write($"{res[i]} ");
            if(i !=0 && i %2 !=0) System.Console.WriteLine();
        }
    }
}
