// В прямоугольной матрице найти строку с наименьшей суммой элементов.

int x, y;

Input(out x, out y);
double[,] matrix = new double[x, y];
FillArray(matrix);
PrintArray(matrix);
System.Console.WriteLine();
System.Console.WriteLine("Строка с наименьшей суммой элементов: " + FindMinIndx(ElmtsMtrx((matrix))));



void Input(out int m, out int n)
{
    System.Console.Write("Введите количество строк массива: ");
    m = Convert.ToInt32(Console.ReadLine());

    System.Console.Write("Введите количество столбцов массива (оно должно отличаться от количества строк): ");
    n = Convert.ToInt32(Console.ReadLine());
    while (m == n)
    {
        System.Console.WriteLine("Количество строк должно отличаться от количества столбцов,"
                                           + " иначе условие задачи не выполняется!");
        Input(out m, out n);
    }

}

void PrintArray(double[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            System.Console.Write($"{arr[i, j],4:F1} |");
        }
        System.Console.WriteLine();
    }
}

void FillArray(double[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = (new Random().NextDouble()) * 30;
        }
    }
}

double[] ElmtsMtrx(double[,] arr)
{
    double[] Summary = new double[arr.GetLength(0)];
    double sum = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            sum = sum + arr[i, j];
        }
        Summary[i] = sum;
        sum = 0;
    }
    return Summary;
}

int FindMinIndx(double[] arr)
{
    int k = 0;
    double min = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] < min)
        {
            min = arr[i];
            k = i;
        }
    }
    return k + 1;
}