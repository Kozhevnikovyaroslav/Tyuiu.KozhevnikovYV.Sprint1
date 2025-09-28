namespace Tyuiu.KozhevnikovYV.Sprint1.Task7.V27.Lib
{
    using tyuiu.cources.programming.interfaces.Sprint1;
    public class DataService : ISprint1Task7V27
    {
        public double Calculate(double x, double y)
        {
            double z = ((Math.Cos(Math.Pow(x, 2)) + Math.Sin(Math.Pow(y, 2))) / (Math.Sin(y) + 1)) - (((x * y) - 12) / (15 + Math.Cos(x)));
            double w = Math.Round(z, 3);
            return w;
        }
    }
}
