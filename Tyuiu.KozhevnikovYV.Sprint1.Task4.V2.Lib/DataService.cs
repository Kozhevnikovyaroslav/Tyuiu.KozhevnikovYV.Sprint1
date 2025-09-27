namespace Tyuiu.KozhevnikovYV.Sprint1.Task4.V2.Lib
{
    using tyuiu.cources.programming.interfaces.Sprint1;
    public class DataService : ISprint1Task4V2
    {
        public double Calculate(double x, double y)
        {
            return 1 / Math.Sqrt(x + 2 * y);
        }
    }
}
