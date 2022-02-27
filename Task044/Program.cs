// Задача 44. Найти точку пересечения двух прямых заданных уравнением y = k1 * x + b1, y = k2 * x + b2, b1 k1 и b2 и k2 заданы

using System;
using System.Text;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;


namespace Explorer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите значение k1 ");
            double k1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите значение  b1 ");
            double b1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите значение k2 ");
            double k2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите значение b2 ");
            double b2 = Convert.ToDouble(Console.ReadLine());

            if (k1 == k2)
                Console.WriteLine("точки пресечения отсутствуют ");
            else
            Console.WriteLine($"Координаты точки пересечения x = {(b2 - b1) / (k1 - k2)}, y ={k1 * (b2 - b1) / (k1 - k2) + b1}");

            
        }
    }
}
