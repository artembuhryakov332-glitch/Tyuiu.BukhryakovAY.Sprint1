using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.BukhryakovAY.Sprint1.Task4.V16.Lib
{
    public class DataService : ISprint1Task4V16
    {
        public double Calculate(double x)
        {
            var output = (1 / (x + 4));
            var res = Math.Round(output,3);

            return res;
        }
    }
}
