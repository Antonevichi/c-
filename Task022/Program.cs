// Задача 22. Найти расстояние между точками в пространстве 2D/3D

//задали все переменные для координатной плоскости
int x1 = 0, x2 = 0, y1 = 0, y2 = 0, z1 = 0, z2 = 0; 
int f = 0;

//определили переменные, обозначающие расстояние между точками, и тип double - ввиду того, что будет  использована Math.Pow
double s = 0, s1 = 0;

// берем вспомогательную переменную, чтобы взаимодействовать с пользователем
string r = String.Empty; 

//метод расчета:
//сопоставляем m - x1, n - x2, c- y1, d - y2
double Rasst (int m, int n, int c, int d) 
{
    double res = 0;
    res = Math.Pow(Math.Pow((n-m),2) + Math.Pow((d-c),2), 0.5);
    return res;
}

// Запрашиваем режим работы 2D или 3D
System.Console.WriteLine("Введите режим расчетов - на плоскости - цифра 2, или в объеме - цифра 3");
r = Console.ReadLine();
f = Convert.ToInt32(r);

if(f == 2)
{
    //Запрашиваем значения точек на координатной плоскости
    System.Console.WriteLine("Введите координату Х1 ");
    r = Console.ReadLine();
    x1 = Convert.ToInt32(r);

    System.Console.WriteLine("Введите координату Х2 ");
    r = Console.ReadLine();
    x2 = Convert.ToInt32(r);

    System.Console.WriteLine("Введите координату Y1 ");
    r = Console.ReadLine();
    y1 = Convert.ToInt32(r);

    System.Console.WriteLine("Введите координату Y2 ");
    r = Console.ReadLine();
    y2 = Convert.ToInt32(r);

    s = Math.Round(Rasst(x1,x2,y1,y2),2);
    System.Console.WriteLine("Расстояние между двумя точками на плоскости 2D равно "+ s);
}
if(f == 3)
{
    System.Console.WriteLine("Введите координату Х1 ");
    r = Console.ReadLine();
    x1 = Convert.ToInt32(r);

    System.Console.WriteLine("Введите координату Х2 ");
    r = Console.ReadLine();
    x2 = Convert.ToInt32(r);

    System.Console.WriteLine("Введите координату Y1 ");
    r = Console.ReadLine();
    y1 = Convert.ToInt32(r);

    System.Console.WriteLine("Введите координату Y2 ");
    r = Console.ReadLine();
    y2 = Convert.ToInt32(r);

    System.Console.WriteLine("Введите координату Z1 ");
    r = Console.ReadLine();
    z1 = Convert.ToInt32(r);

    System.Console.WriteLine("Введите координату Z2 ");
    r = Console.ReadLine();
    z2 = Convert.ToInt32(r);
    
    //находим проекцию на плоскость [Х,Y]
    s = Rasst(x1,x2,y1,y2);

    //рассчитываем расстояние между точками, используя проекцию и высоту по оси Z
    s1 = Math.Pow(Math.Pow(s,2) + Math.Pow((z2-z1),2), 0.5);
    s1 = Math.Round(s1, 2);
    System.Console.WriteLine("Расстояние между двумя точками в объеме 3D равно "+ s1);
}
if(f != 2 && f != 3) System.Console.WriteLine("Расчет по введенному режиму невозможен!");