// Задача №28. Подсчитать сумму цифр в числе

int a = 0, sum = 0;
string s = String.Empty;

System.Console.WriteLine("Введите число ");
s = Console.ReadLine();
a = Convert.ToInt32(s);

while (a!= 0)
{
    sum = sum + a%10;
    a = a/10;
}

System.Console.WriteLine("Сумма цифр в числе равна " + sum);