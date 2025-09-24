using System;
using Tyuiu.BukhryakovAY.Sprint1.Task7.V21.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine(" Формула: (y^x) / (cos(x) - x/3) + ((sin(x)^2 + cos(y)) / (cos(x) - sin(y))) * tan(x*y)");
        Console.WriteLine("Введите значение X: ");
        double x = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите значение Y: ");
        double y = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");
        var res = ds.Calculate(x,y);
        Console.WriteLine(res);
    }
}