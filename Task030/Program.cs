// Задача № 30. Показать кубы чисел, заканчивающихся на четную цифру

int a = 0;
double grade = 0;
string s;

System.Console.WriteLine("Введите число ");
s = Console.ReadLine();
a = Convert.ToInt32(s);

while (a!=0) // программа выполняется до тех пор, пока не пользователь не введет 0
{
    if (a%2 == 0)
    {
        grade = Math.Pow(a, 3);
        System.Console.WriteLine($"Куб числа "+ a +" равен " + grade);
    }
    System.Console.WriteLine("Введите число ");
    s = Console.ReadLine();
    a = Convert.ToInt32(s);
}
