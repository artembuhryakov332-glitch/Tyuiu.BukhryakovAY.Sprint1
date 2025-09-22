using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.BukhryakovAY.Sprint1.Task5.V5.Lib
{
    public class DataService : ISprint1Task5V5
    {
        public int Calculate(double x)
        {
            char[] number = x.ToString().ToCharArray();
            int dotIndex = Array.IndexOf(number, ',');
            char numberAfterDot = number[dotIndex + 1];
            return numberAfterDot - '0';
        }
    }
}
 