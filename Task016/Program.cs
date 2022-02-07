// Задача 16. Дано число обозначающее день недели. Выяснить является номер дня недели выходным

int vvodChisla()
{
  int number = 0;
  Console.WriteLine("Введите цифру, обозначающую день недели:");
  if (!int.TryParse(Console.ReadLine(), out number))
    {
     Console.WriteLine("Введите целое число! По умолчанию установлено значение 0.");
    }   
      return number;
        }
        int a = vvodChisla();
          if (a > 0)
        {
          if(a < 8)
        {
          if (a < 6)
        {
          Console.WriteLine($"Будний день");
          return;
        } Console.WriteLine($"Выходной день");
          return;
    }
}
Console.WriteLine("Такой день недели не существует!");