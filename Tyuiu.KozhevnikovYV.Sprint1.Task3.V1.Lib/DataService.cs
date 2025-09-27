namespace Tyuiu.KozhevnikovYV.Sprint1.Task3.V1.Lib
{
    using tyuiu.cources.programming.interfaces.Sprint1;
    public class DataService : ISprint1Task3V1
    {
        public double CylinderVolume(double r, double h)
        {
            double pi = 3.14159;
            double a = (r * r * pi) * h;
            double b = Math.Round(a, 3);
            return b;
        }
    }
}
