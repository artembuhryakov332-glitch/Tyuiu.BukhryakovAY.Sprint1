using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.BukhryakovAY.Sprint1.Task3.V19.Lib
{
    public class DataService : ISprint1Task3V19
    {
        public bool ElephCanMove(double x1, double x2, double y1, double y2)
        {
            var resultX = x1 - x2;
            var resultY = y1 - y2;

            if (Math.Abs(resultX) != Math.Abs(resultY))
            {
                return false;   
            }
            else
            {
                return true;
            }

        }
    }
}
