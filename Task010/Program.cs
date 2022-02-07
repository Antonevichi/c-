// Задача 10:** Показать вторую цифру трёхзначного числа.

class Program
{
    static void Main(string[] args)
    {
        var n = Math.Abs(Convert.ToInt64(Console.ReadLine()));

        while (n >= 100)
        {
            n /= 10;
        }

        var r = n % 10;

        Console.WriteLine(r);
    }
}