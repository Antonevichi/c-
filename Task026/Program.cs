//Задача №26. Возведите число А в натуральную степень B используя цикл

int a = 0, b = 0, result = -1;
string s = String.Empty;

System.Console.WriteLine("Введите число ");

s = Console.ReadLine();
a = Convert.ToInt32(s);

System.Console.WriteLine("Введите степень числа ");

s = Console.ReadLine();
b = Convert.ToInt32(s);

int Grade(int s, int x)
{
    int res = -1;
    for (int i = 0; i < x; i++)
    {
        res = s*s;
    }
    return res;
}

result = Grade(a,b);
System.Console.WriteLine($"Результат возведения числа " + a + " в степень " + b + " равно " + result);