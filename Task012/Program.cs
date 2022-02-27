// Задача 12:** Удалить вторую цифру трёхзначного числа.int a = 123;

int vvodChisla()
{
    int number = 0;
    Console.WriteLine("Введите трехзначное число:");
    if (!int.TryParse(Console.ReadLine(), out number))
    {
        Console.WriteLine("Введите целое число! По умолчанию установлено значение 0.");
    }return number;
}
int a = vvodChisla();
if (a > 99)
{
    if(a < 1000)
        {
        int b = a % 10;
        a = a / 100 * 10 + b;
        Console.WriteLine($"После удаления  второй цифры получится: {a}");
        return;
        }
        }
        if (a < -99)
        {
        if(a > -1000)
        {
        int b = a % 10;
        a = a / 100 * 10 + b;
        Console.WriteLine($"Если удалить вторую цифру получится: {a}");
        return;
        }
}
Console.WriteLine("Введите трехзначное число!");