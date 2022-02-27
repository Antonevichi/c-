// Задача №40. В Указанном массиве вещественных чисел найдите разницу между максимальным и минимальным элементом

double a = 0;
string s = String.Empty;

System.Console.WriteLine("Задайте произвольный массив, поочередно вводя числа. Числа могут быть  целыми, и вещественными.");
System.Console.WriteLine("Разделитель целой и дробной части - запятая. По окончании введите 0");
s = Console.ReadLine();
a = Convert.ToDouble(s);

List<double> Num = new List<double> {};

while (a != 0)
{
    Num.Add(a);
    System.Console.WriteLine("Задайте следующее число");
    s = Console.ReadLine();
    a = Convert.ToDouble(s);
}

double [] N = Num.ToArray<double>();

for (int i = 0; i < N.Length; i++)
{
    System.Console.Write(N[i] + " | ");
} 

double max = N[0];
double min = N[0];
for (int i = 0; i < N.Length; i++)
{
    if(N[i] > max) max = N[i];
    if(N[i] < min) min = N[i];
}
System.Console.WriteLine();
System.Console.WriteLine("Разница между максимальным и минимальным элементами равна " + (max - min));