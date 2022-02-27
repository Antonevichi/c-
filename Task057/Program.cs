// Написать программу, упорядочивания по убыванию элементов каждой строки двумерного массива.


int x = 0, y = 0;

Input(out x, out y);
double[,] matrix = new double[x, y];
FillArray(matrix, x, y);
PrintArray(matrix);
System.Console.WriteLine("Массив после упорядочивания строк по убыванию:");
SortElemnts(matrix);
PrintArray(matrix);



void Input(out int m, out int n)
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
    for (int i = 0; i < a; i++)
    {
        for (int j = 0; j < b; j++)
        {
            arr[i, j] = Convert.ToDouble(new Random().Next(1, 100));
        }
    }
}
void PrintArray(double[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            System.Console.Write($"{arr[i, j],4} |");
        }
        System.Console.WriteLine();
    }
}
void SortElemnts(double[,] arr)
{
    double min = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1) - 1; j++)
        {
            if (arr[i, j] < arr[i, j + 1])
            {
                min = arr[i, j];
                arr[i, j] = arr[i, j + 1];
                arr[i, j + 1] = min;
                min = 0;
            }
        }
    }
}