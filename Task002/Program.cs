//Задача 2: Даны два числа. Показать большее и меньшее число


using System;
using System.Linq;
 
class  Program
{
    
    public static void Main()
    {
        
        Console.WriteLine("Введите два числа : ");
        {
            Console.WriteLine(String.Join(" большее число, меньшее число ", Console.ReadLine().Split().Select(Int32.Parse).OrderByDescending(x => x)));
        } 
       
    }

       
}