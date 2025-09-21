using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.BukhryakovAY.Sprint1.Task2.V25.Lib
{
    public class DataService : ISprint1Task2V25
    {
        public double ConvertRadsToDegrees(int value)
        {
            var res = (value * 180) / Math.PI;
            res = Math.Round(res,3);
            return res;
        }
    }
}
