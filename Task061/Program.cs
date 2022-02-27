// Найти произведение двух матриц

int x, y, m, n;

Input(out x, out y, out m, out n);
int[,] matrix1 = new int[x, y];
FillArray(matrix1);
PrintArray(matrix1);
int[,] matrix2 = new int[m, n];
FillArray(matrix2);
System.Console.WriteLine();
PrintArray(matrix2);
System.Console.WriteLine("Произведение двух матриц равно:");
PrintArray(MultiMatrix(matrix1, matrix2));




void Input(out int k, out int l, out int s, out int p)
{
    System.Console.Write("Введите количество строк матрицы 1: ");
    k = int.Parse(Console.ReadLine());

    System.Console.Write("Введите количество столбцов матрицы 1: ");
    l = int.Parse(Console.ReadLine());

    System.Console.Write("Введите количество строк матрицы 2: ");
    s = int.Parse(Console.ReadLine());

    System.Console.Write("Введите количество строк матрицы 2: ");
    p = int.Parse(Console.ReadLine());

    while(l!=s)
    {
        System.Console.WriteLine("Количество столбцов матрицы 1 должно быть равно количеству строк матрицы 2!");
        Input(out k, out l, out s, out p);
    }
}

void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            System.Console.Write($"{arr[i, j],2} |");
        }
        System.Console.WriteLine();
    }
}

void FillArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(1, 10);
        }
    }
}

int[,] MultiMatrix(int[,] arr1, int[,] arr2)
{
    int[,] matrix = new int[arr1.GetLength(0), arr2.GetLength(1)];
    int sum = 0;
    for (int i = 0; i < arr1.GetLength(0); i++)
    {
        for (int j = 0; j < arr2.GetLength(1); j++)
        {
            for (n = 0; n < arr1.GetLength(1); n++)
            {
                sum = sum + arr1[i, n] * arr2[n, j];
            }
            matrix[i, j] = sum;
            sum = 0;
        }
    }
    return matrix;
}
