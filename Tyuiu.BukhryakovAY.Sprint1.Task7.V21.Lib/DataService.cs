using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.BukhryakovAY.Sprint1.Task7.V21.Lib
{
    public class DataService : ISprint1Task7V21
    {
        public double Calculate(double x, double y)
        {
            double z;
            z = ((Math.Pow(y,x)/(Math.Acos(x)-x/3)) + ((Math.Asin(Math.Sqrt(x)) + Math.Acos(y))*Math.Atan(x*y))/(Math.Acos(x) - Math.Asin(y))); 
            return Math.Round(z,3);
        }
    }
}
