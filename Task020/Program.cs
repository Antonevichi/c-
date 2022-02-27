//Задача № 20. Задать номер четверти, показать диапазоны для возможных координат

int a = 0;
string s = String.Empty;

System.Console.WriteLine("Задайте номер четверти координатной плоскости ");
s = Console.ReadLine();
a = Convert.ToInt32(s);

if(a == 1) System.Console.WriteLine("Диапазоны возможных координат: по осям Х и Y - от 0 до " + double.MaxValue);
if(a == 2) System.Console.WriteLine("Диапазоны возможных координат: по оси Х - от " + double.MinValue + " до 0; по оси Y - от 0 до " + double.MaxValue);
if(a == 3) System.Console.WriteLine("Диапазоны возможных координат: по осям Х и Y - от " + double.MinValue + " до 0");
if(a == 4) System.Console.WriteLine("Диапазоны возможных координат: по оси Х - от 0 до " + double.MaxValue + "; по оси Y - от " + double.MinValue + " до 0");
