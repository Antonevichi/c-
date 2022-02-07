// Задача 8: Показать чётные числа от 1 до N. 

int vvodChisla()
{
    int number = 0;
    Console.WriteLine("Введите число N:");
    if (!int.TryParse(Console.ReadLine(), out number))
    {
        Console.WriteLine("Введите целое число! По умолчанию  значение 0.");
    }return number;
    }
       int N = vvodChisla();
       int i = 2;
       Console.WriteLine($"Четные числа в промежутке от 1 до {N}:");
       while(i <= N)
    {
    Console.WriteLine(i);
    i += 2;
}