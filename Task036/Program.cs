/* Задача №36. Задать массив, заполнить случайными положительными трёхзначными числами. 
 Показать количество нечетных\четных чисел
*/

int [] Arr = new int [10];
int Odd = 0, Even = 0;

for(int i=0; i < Arr.Length; i++)
{
    Arr[i] = new Random().Next(99, 1000);
    System.Console.Write($"{Arr[i]}" + " ");
    if (Arr[i]%2 == 0) Odd++;
    else Even++;
}

System.Console.WriteLine();
System.Console.WriteLine("Количество четных элементов массива " + Odd);
System.Console.WriteLine("Количество нечетных элементов массива " + Even);