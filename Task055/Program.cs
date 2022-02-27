// задача 55. Дан целочисленный массив. Найти среднее арифметическое каждого из столбцов


int x = 0, y = 0;

Input(out x, out y);
int[,] matrix = new int[x, y];
FillArray(matrix, x, y);
PrintArray(matrix);
System.Console.WriteLine("Среднее арифметическое каждого столбца:");
PrintAvrgMassiv(matrix, y);



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
void FillArray(int[,] arr, int a, int b)
{
    for (int i = 0; i < a; i++)
    {
        for (int j = 0; j < b; j++)
        {
            arr[i, j] = new Random().Next(1, 100);
        }
    }
}
void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            System.Console.Write($"{arr[i, j],3} |");
        }
        System.Console.WriteLine();
    }
}
double Avrg(double a, int b)
{
    return Math.Round(a / b, 1);
}
void PrintAvrgMassiv(int[,] arr, int a)
{
    double sum = 0;
    double[] array = new double[a];
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            sum = sum + arr[i, j];
        }
        array[j] = Avrg(sum, arr.GetLength(0));
        sum = 0;
    }
    for (int j = 0; j < array.Length; j++)
    {
        System.Console.Write($"{array[j],3} |");
    }
}