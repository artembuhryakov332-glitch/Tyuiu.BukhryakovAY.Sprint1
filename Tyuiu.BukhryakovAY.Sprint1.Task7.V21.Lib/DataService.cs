﻿using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.BukhryakovAY.Sprint1.Task7.V21.Lib
{
    public class DataService : ISprint1Task7V21
    {
        public double Calculate(double x, double y)
        {
            double z;
            z = (Math.Pow(y, x)) / (Math.Cos(x) - x / 3) + ((Math.Sin(x*x) + Math.Cos(y)) / (Math.Cos(x) - Math.Sin(y))) * Math.Tan(x * y);
            return Math.Round(z,3);
        }
    }
}
