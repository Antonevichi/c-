// Задача 42. Определить сколько чисел больше 0 введено с клавиатуры

int a = 0, sum = 0;
string s;

System.Console.WriteLine("Введите любое целое число. Для окончания процесса введите 0");

s = Console.ReadLine();
a = Convert.ToInt32(s);

while (a!=0)
{
    if(a > 0) sum++;

    System.Console.WriteLine("введите следующее число. или 0:");
    s = Console.ReadLine();
    a = Convert.ToInt32(s);
}

if(sum>0) System.Console.WriteLine("Количество чисел более ноля составляет " + sum);
else System.Console.WriteLine("Положительных чисел не введено");