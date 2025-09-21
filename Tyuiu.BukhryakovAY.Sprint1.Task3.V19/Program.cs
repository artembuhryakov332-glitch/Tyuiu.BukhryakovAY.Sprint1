using Tyuiu.BukhryakovAY.Sprint1.Task3.V19.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");
        double x1 = 5;
        double y1 = 7;
        double x2 = 8;
        double y2 = 4;
        Console.WriteLine("Координаты слона по X и Y - " + x1 + " и " + y1);
        Console.WriteLine("Возможный ход слона по X и Y - " + x2 + " и " + y2);
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine(ds.ElephCanMove(x1, x2, y1, y2));
    }
}