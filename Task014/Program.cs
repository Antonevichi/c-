//Задача 14. Найти третью цифру числа или сообщить, что её нет.

int vvodChisla()
{
    int number = 0;
    Console.WriteLine("Введите число:");
    if (!int.TryParse(Console.ReadLine(), out number))
    {
       Console.WriteLine("Введите целое число! По умолчанию установлено значение 0.");
    }  return number;
}
       int a = vvodChisla();
       if(a > 99)
    {
       string b = Convert.ToString(a);
       Console.WriteLine($"Третья цифра числа: {b[2]}");
       return;
    }
       if(a < -99)
{
       string b = Convert.ToString(a);
       Console.WriteLine($"Третья цифра числа: {b[3]}");
       return;
}
       Console.WriteLine("Третья цифра отсуствует");