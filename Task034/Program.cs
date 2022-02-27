//Задача №34. Написать программу замену элементов массива на противоположные


int N = 10;
int [] a = new int [N];

void Input(int [] arr)
{
    Random random = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = random.Next(1,100);
    }
}

void Solve(int [] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = -arr[i];
    }
}

void Print(int [] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        System.Console.Write($"{arr[i]} ");
    }
}
Input(a);
Print(a);
Solve(a);
System.Console.WriteLine();
Print(a);